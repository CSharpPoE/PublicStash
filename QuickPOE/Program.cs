using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace PublicStash
{
    class Program
    {
        //public static void Main(String[]args)
        //{
        //    Run();
        //    //CheckForBugs();
        //    //regex();
        //}

        public static void regex()
        {
            var r = File.ReadAllText("C:\\Users\\Sebastian\\Desktop\\TestName.txt");

            var res = Regex.Matches(r, @">[\w\s']+").Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

            var newres = res.Select(e => $"\"{e.Replace(">", "")}\",");


            //var stream = File.CreateText("C:\\tmp\\poe\\test.txt");
            File.WriteAllLines("C:\\tmp\\poe\\test.txt", newres);
        }

        public static void Run()
        {
            for (;;)
            {
                var id = API.GetLatestStashIdAsync().Result;
                //var g = API.GetPublicStashAsync("121928813-127692069-119776199-138031744-129023880").Result;
                var g = API.GetPublicStashAsync(id).Result;

                var list = (from stash in g.stashes from item in stash.items where item != null select item).ToList();

                if ( list.Any() )
                {
                }

                Thread.Sleep(10000);
            }
        }

        public static void CheckForBugs()
        {
            var stopwatch = new Stopwatch();

            for (;;)
            {
                //stopwatch.Start();

                var id = API.GetLatestStashIdAsync().Result;
                var g = API.GetPublicStashAsync(id).Result;

                //stopwatch.Stop();
                //var time = stopwatch.Elapsed;
                //stopwatch.Reset();

                var list = (from stash in g.stashes from item in stash.items where item != null select item).ToList();

                if ( list.Any() )
                {
                }

                Thread.Sleep(10000);
            }
        }
    }
}