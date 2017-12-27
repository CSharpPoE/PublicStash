using System;
using System.Collections.Generic;
using System.Linq;
using QuickPOE.Model;

namespace QuickPOE
{
    public class Example
    {
        public static void Main(string[] args)
        {
            var publicStash = API.GetLatestPublicStashAsync().Result;
            //var publicStash = API.GetPublicStashAsync("123241175-129034376-121043481-139470373-130405801").Result;

            var KnifeList = GetAllUsersWithEtherealKnivesGemsIntheirStashIfAny(publicStash);
            var BeltList = GetAllWhoHasPricedTheirStygianVise(publicStash);
            var CurrencyDict = GetAllCurrencyAndAddThemUp(publicStash);
            var MapList = GetInterestingMapsListedForLessOrEqualToFifteenChaos(publicStash);
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