using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using PathOfExile;
using PathOfExile.Model;
using PublicStashExample.Example.Trade;
using Currency = PathOfExile.Model.Currency;


namespace PublicStashTester
{
    public class Example
    {
        public static void Main(string[] args)
        {
            GatherSocketableItems();
            //RunTrader();
            //FunSmallExamples(publicStash);
            //Run(new List<Action> {RunTrader, GatherSocketableItems});
        }

        public static void Run(List<Action> actions, int delay = 10000)
        {
            // ReSharper disable once NotAccessedVariable
            var iteration = 0;
            var publicStash = PublicStashAPI.GetAsync().Result;
            var nextChangeId = publicStash.next_change_id;
            var cachedChangeId = "";

            for (;;)
            {
                if (cachedChangeId != nextChangeId)
                {
                    foreach (var action in actions) action();

                    iteration += 1;
                    cachedChangeId = nextChangeId;
                }
                else
                {
                    publicStash = PublicStashAPI.GetAsync(nextChangeId).Result;
                    nextChangeId = publicStash.next_change_id;
                    Thread.Sleep(delay);
                }
            }
        }

        private static void GatherSocketableItems()
        {
            // ReSharper disable once NotAccessedVariable
            var iteration = 0;

            var publicStash = PublicStashAPI.GetAsync().Result;
            var nextChangeId = publicStash.next_change_id;
            var cachedChangeId = "";

            var armours = new List<(Armour, String)>();
            var weapons = new List<(Weapon, String)>();
            var unspecified = new List<(UnspecifiedItem, String)>();

            for (;;)
            {
                if (armours.Any() || weapons.Any() || unspecified.Any())
                {
                }

                if (cachedChangeId != nextChangeId)
                {
                    //missing.AddRange(prices.Where(e => e.Buying.Currency == PublicStashExample.Example.Trade.Currency.MISSING_TYPE).ToList

                    //(from missing in prices.Where(e =>
                    //        e.Buying.Currency == PublicStashExample.Example.Trade.Currency.MISSING_TYPE)
                    //    where !lines.Contains(missing.Buying.Texted)
                    //    select missing.Buying.Texted).ToList();

                    foreach (var stash in publicStash.stashes)
                    {
                        foreach (var item in stash.items)
                        {
                            var type = item.GetType();
                            if (type == typeof(Armour))
                            {
                                var a = (Armour) item;

                                if (a.socketedItems.Any()) armours.Add((a, cachedChangeId));
                            }
                            else if (type == typeof(Weapon))
                            {
                                var w = (Weapon) item;

                                if (w.socketedItems.Any()) weapons.Add((w, cachedChangeId));
                            }
                            else if (type == typeof(UnspecifiedItem))
                            {
                                // ReSharper disable once UnusedVariable
                                var lines = File.ReadAllLines("C:/tmp/poe/missItem.txt");
                                unspecified.Add(((UnspecifiedItem) item, cachedChangeId));
                                File.AppendAllLines("C:/tmp/poe/missItem.txt",
                                    new[] {$"{item.typeLine} - {cachedChangeId}"});
                            }
                        }
                    }

                    iteration++;
                    cachedChangeId = nextChangeId;
                }
                else
                {
                    publicStash = PublicStashAPI.GetAsync(nextChangeId).Result;
                    nextChangeId = publicStash.next_change_id;
                    Thread.Sleep(10000);
                }
            }
        }

        private static void RunTrader()
        {
            // ReSharper disable once NotAccessedVariable
            var iteration = 0;

            var publicStash = PublicStashAPI.GetAsync().Result;
            var nextChangeId = publicStash.next_change_id;
            var cachedChangeId = "";
            var trader = new PoeTrader();

            for (;;)
            {
                if (cachedChangeId != nextChangeId)
                {
                    var prices = trader.GetCurrencyListings(publicStash);
                    //missing.AddRange(prices.Where(e => e.Buying.Currency == PublicStashExample.Example.Trade.Currency.MISSING_TYPE).ToList
                    iteration++;

                    var lines = File.ReadAllLines("C:/tmp/poe/err.txt");
                    var tmp =
                    (from missing in prices.Where(e =>
                            e.Buying.Currency == PublicStashExample.Example.Trade.Currency.MISSING_TYPE)
                        where !lines.Contains(missing.Buying.Texted)
                        select missing.Buying.Texted).ToList();

                    if (tmp.Contains("port"))
                    {
                    }

                    if (tmp.Any())
                    {
                        File.AppendAllLines("C:/tmp/poe/err.txt", new HashSet<String>(tmp));
                    }

                    cachedChangeId = nextChangeId;
                }
                else
                {
                    publicStash = PublicStashAPI.GetAsync(nextChangeId).Result;
                    nextChangeId = publicStash.next_change_id;
                    Thread.Sleep(5000);
                }
            }
        }

        private static void FunSmallExamples(PublicStash publicStash)
        {
            //var KnifeList = GetAllUsersWithEtherealKnivesGemsIntheirStashIfAny(publicStash);
            //var BeltList = GetAllWhoHasPricedTheirStygianVise(publicStash);
            //var CurrencyDict = GetAllCurrencyAndAddThemUp(publicStash);
            //var MapList = GetInterestingMapsListedForLessOrEqualToFifteenChaos(publicStash);
        }

        private static List<(String, Gem)> GetAllUsersWithEtherealKnivesGemsIntheirStashIfAny(PublicStash ps)
        {
            var list = new List<(String, Gem)>();

            foreach (var stash in ps.stashes)
            {
                foreach (var item in stash.items)
                {
                    switch (item)
                    {
                        case Gem gem when item.GetType() == typeof(Gem):
                            if (gem.typeLine == "Ethereal Knives")
                            {
                                list.Add((stash.accountName, gem));
                            }
                            break;
                    }
                }
            }

            return list;
        }

        private static List<(String, Belt)> GetAllWhoHasPricedTheirStygianVise(PublicStash ps)
        {
            var list = new List<(String, Belt)>();

            foreach (var stash in ps.stashes)
            {
                foreach (var item in stash.items)
                {
                    switch (item)
                    {
                        case Belt belt when item.GetType() == typeof(Belt):
                            if (belt.typeLine == "Stygian Vise" &&
                                belt.note?.IndexOf("~") >= 0)
                            {
                                list.Add((stash.accountName, belt));
                            }
                            break;
                    }
                }
            }

            return list;
        }

        public static Dictionary<String, int> GetAllCurrencyAndAddThemUp(PublicStash ps)
        {
            var dict = new Dictionary<String, int>();

            foreach (var stash in ps.stashes)
            {
                foreach (var item in stash.items)
                {
                    switch (item)
                    {
                        case Currency currency when item.GetType() == typeof(Currency):
                            dict.TryGetValue(currency.typeLine, out var current);
                            current += currency.stackSize;
                            dict[currency.typeLine] = current;

                            break;
                    }
                }
            }

            return dict;
        }

        private static List<(String, Map)> GetInterestingMapsListedForLessOrEqualToFifteenChaos(PublicStash ps)
        {
            var maps = new List<String>
            {
                "Scriptorium Map",
                "Shaped Scriptorium Map",
                "Vault Map",
                "Shaped Vault Map",
                "Shaped Spider Forest Map",
                "Shaped Arachnid Tomb Map",
            };

            bool LessThenFiveC(String cond)
            {
                if (String.IsNullOrEmpty(cond)) return false;

                for (var i = 0; i < 15; i++)
                {
                    if (cond.IndexOf($"~price {i} chaos", StringComparison.Ordinal) >= 0 ||
                        cond.IndexOf($"~b/o {i} chaos", StringComparison.Ordinal) >= 0)
                    {
                        return true;
                    }
                }

                return false;
            }

            var list = new List<(String, Map)>();

            foreach (var stash in ps.stashes)
            {
                foreach (var item in stash.items)
                {
                    switch (item)
                    {
                        case Map map when item.GetType() == typeof(Map):
                            if (maps.Any(m => map.typeLine.IndexOf(m, StringComparison.Ordinal) >= 0 &&
                                              LessThenFiveC(map.note)))
                            {
                                list.Add((stash.accountName, map));
                            }
                            break;
                    }
                }
            }

            return list;
        }
    }
}