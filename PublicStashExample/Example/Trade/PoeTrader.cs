using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PoEPublicStash.Model;

namespace PublicStashExample.Example.Trade
{
    class PoeTrader
    {
        private static readonly IEnumerable<String> matches = new List<String>
        {
            "~price ",
            "~b/o "
        };

        public IEnumerable<Price> GetPrice(PublicStash ps)
        {
            var prices = new List<Price>();

            foreach (var stash in ps.stashes)
            {
                foreach (var item in stash.items)
                {
                    switch (item)
                    {
                        case Currency curr when item.note != null && item.GetType() == typeof(Currency):

                            foreach (var query in matches)
                            {
                                if (curr.note?.IndexOf(query) >= 0)
                                {
                                    var matchedText = Regex.Matches(curr.note, $@"^{query}[0-9//]+ [\w-]+")
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToArray();

                                    if (matchedText.Length == 1)
                                    {
                                        var parsedString = ParseString(query, matchedText[0]);

                                        if (parsedString[0].Contains("/"))
                                        {
                                            var decimalPrice = parsedString[0].Split('/');
                                            var price = new Price(
                                                new Seller(stash.accountName, stash.lastCharacterName, curr.league),
                                                decimal.Divide(
                                                    decimal.Parse(decimalPrice[1]),
                                                    decimal.Parse(decimalPrice[0])),
                                                $"Selling {decimalPrice[1]} {curr.typeLine} for {decimalPrice[0]} {parsedString[1]}",
                                                matchedText[0],
                                                new Sell(curr.typeLine, int.Parse(decimalPrice[1])),
                                                new Buy(parsedString[1], int.Parse(decimalPrice[0])));
                                            prices.Add(price);
                                        }
                                        else
                                        {
                                            var price = new Price(
                                                new Seller(stash.accountName, stash.lastCharacterName, curr.league),
                                                decimal.Parse(parsedString[0]),
                                                $"Selling {curr.stackSize} {curr.typeLine} for {int.Parse(parsedString[0]) * curr.stackSize} {parsedString[1]}",
                                                matchedText[0],
                                                new Sell(curr.typeLine, curr.stackSize),
                                                new Buy(parsedString[1], int.Parse(parsedString[0])));
                                            prices.Add(price);
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }

            return prices;
        }

        private static string[] ParseString(String replace, String value) => value.Replace(replace, "").Split(null);
    }
}