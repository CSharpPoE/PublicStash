using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PathOfExile.Model;
using PoECurrency = PathOfExile.Model.Items.Currencies.Currency;

namespace PublicStashExample.Example.Trade
{
    public class PoeTrader
    {
        private static readonly IEnumerable<String> matches = new List<String>
        {
            "~price ",
            "~b/o "
        };

        public IEnumerable<Price> GetCurrencyListings(PublicStash ps)
        {
            var prices = new List<Price>();

            foreach (var stash in ps.Stashes)
            {
                foreach (var item in stash.Items)
                {
                    switch (item)
                    {
                        case PoECurrency curr when item.Note != null &&
                                                   item.GetType() ==
                                                   typeof(PoECurrency):

                            foreach (var query in matches)
                            {
                                if (curr.Note?.IndexOf(query) >= 0)
                                {
                                    var matchedText = Regex.Matches(curr.Note, $@"^{query}[0-9//]+ [\w-]+")
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToArray();

                                    if (matchedText.Length == 1)
                                    {
                                        var parsedCurrency = ParseCurrency(query, matchedText[0]);

                                        if (parsedCurrency[0].Contains("/"))
                                        {
                                            var decimalPrice = parsedCurrency[0].Split('/');

                                            // Missing value "/X" or "X/"
                                            if (String.IsNullOrEmpty(decimalPrice[0]) ||
                                                String.IsNullOrEmpty(decimalPrice[1])) break;

                                            // Missing value "/X" or "X/"
                                            if (int.Parse(decimalPrice[0]) == 0 ||
                                                int.Parse(decimalPrice[1]) == 0) break;


                                            var price = new Price(
                                                new Seller(stash.accountName, stash.lastCharacterName, curr.League),
                                                decimal.Divide(
                                                    decimal.Parse(decimalPrice[1]),
                                                    decimal.Parse(decimalPrice[0])),
                                                $"Selling {decimalPrice[1]} {curr.TypeLine} for {decimalPrice[0]} {parsedCurrency[1]}",
                                                matchedText[0],
                                                new Sell(curr.TypeLine, int.Parse(decimalPrice[1])),
                                                new Buy(parsedCurrency[1], int.Parse(decimalPrice[0])));
                                            prices.Add(price);
                                        }
                                        else
                                        {
                                            var price = new Price(
                                                new Seller(stash.accountName, stash.lastCharacterName, curr.League),
                                                decimal.Parse(parsedCurrency[0]),
                                                $"Selling {curr.StackSize} {curr.TypeLine} for {int.Parse(parsedCurrency[0]) * curr.StackSize} {parsedCurrency[1]}",
                                                matchedText[0],
                                                new Sell(curr.TypeLine, curr.StackSize),
                                                new Buy(parsedCurrency[1],
                                                    curr.StackSize * int.Parse(parsedCurrency[0])));
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

        private static string[] ParseCurrency(String replace, String value) => value.Replace(replace, "").Split(null);
    }
}