using System;
using System.Linq;
using System.Threading;
using PathOfExile;
using PathOfExile.Model.Items.Beast;
using PathOfExile.Model.Items.Currency;

namespace PoEPublicStash
{
    class Program
    {
        public static void Main(String[] args)
        {
            //var t = PublicStashAPI.GetLatestStashIdAsync().Result;
            Run();
            //CheckForBugs();
            //CheckForBugs2();
            //regex();
        }

        public static void Run()
        {
            var iterations = 0;
            for (;;)
            {
                var id = PublicStashAPI.GetLatestStashIdAsync().Result;
                //var g = PublicStashAPI.GetAsync("137293499-143655459-134858781-155093696-145277041").Result;
                var g = PublicStashAPI.GetAsync(id).Result;

                var currency = g.stashes.SelectMany(e => e.items.Select(item =>
                {
                    if ( item is Currency c ) return c;
                    else return null;
                })).Where(i => i != null).ToList();

                var list2 = (from stash in g.stashes from item in stash.items where item != null select item).ToList();

                //var list = (from stash in g.stashes
                //    from item in stash.items
                //    where item.GetType() == typeof(PathOfExile.Model.Items.UnspecifiedItem)
                //    select item).ToList();

                //if (list.Any())
                //{
                //}

                //var beasts = g.stashes.Select(stash => stash.items.Where(item => item.GetType() == typeof(Beast)).Select(e => e).ToList()).ToList();

                Thread.Sleep(10000);
                iterations++;
            }
        }

        //public static void regex()
        //{
        //    var r = File.ReadAllText("C:\\Users\\Sebastian\\Desktop\\TestName.txt");

        //    var res = Regex.Matches(r, @">[\w\s']+").Cast<Match>()
        //        .Select(m => m.Value)
        //        .ToArray();

        //    var newres = res.Select(e => $"\"{e.Replace(">", "")}\",");


        //    //var stream = File.CreateText("C:\\tmp\\poe\\test.txt");
        //    File.WriteAllLines("C:\\tmp\\poe\\test.txt", newres);
        //}


        //public static void CheckForBugs()
        //{
        //    var stopwatch = new Stopwatch();
        //    var list = new List<Item>();
        //    //var list2 = new List<Item>();

        //    for (; ; )
        //    {
        //        try
        //        {
        //            stopwatch.Start();

        //            var id = PublicStashAPI.GetLatestStashIdAsync().Result;
        //            var g = PublicStashAPI.GetAsync(id).Result;

        //            //var g = PublicStashAPI.GetAsync("137293499-143655459-134858781-155093696-145277041").Result;


        //            stopwatch.Stop();
        //            var time = stopwatch.Elapsed;
        //            stopwatch.Reset();

        //            //list2.AddRange((from stash in g.stashes
        //            //    from item in stash.items
        //            //    select item).ToList());


        //            list.AddRange((from stash in g.stashes
        //                           from item in stash.items
        //                           where item.GetType() == typeof(UnspecifiedItem)
        //                           select item).ToList());

        //            if ( list.Any() )
        //            {
        //            }

        //            Thread.Sleep(10000);
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}

        //public static void CheckForBugs2()
        //{
        //    var stopwatch = new Stopwatch();

        //    for (; ; )
        //    {
        //        stopwatch.Start();

        //        //var id = PublicStashAPI.GetLatestStashIdAsync().Result;
        //        //var g = PublicStashAPI.GetAsync(id).Result;

        //        //var g = PublicStashAPI.GetAsync("137293499-143655459-134858781-155093696-145277041").Result;

        //        //var g = JsonConvert.DeserializeObject<Piece>(
        //        //    "{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":84,\"icon\":\"http://web.poecdn.com/image/Art/2DItems/Belts/Shards/HarbingerBeltShard2.png?scale=1&scaleIndex=0&w=1&h=1&v=58e87397b6d39f7aeb0d80e0e91edbcb3\",\"league\":\"Standard\",\"id\":\"e57fd152759b3d341bd3e58d1186f4277bf59d36ca4e3a9a82a30e70cb5c2341\",\"name\":\"<<set:MS>><<set:M>><<set:S>>Second Piece of Time\",\"typeLine\":\"Cloth Belt Piece\",\"identified\":true,\"note\":\"~b/o 8 alch\",\"descrText\":\"This item will transform when correctly arranged with other items.\",\"frameType\":3,\"category\":{\"currency\":[\"piece\"]},\"x\":2,\"y\":2,\"inventoryId\":\"Stash12\"}");

        //        //var g = JsonConvert.DeserializeObject<Item>(
        //        //    "{\"verified\":false,\"w\":2,\"h\":1,\"ilvl\":53,\"icon\":\"http:\\/\\/web.poecdn.com\\/image\\/Art\\/2DItems\\/Belts\\/AbyssBelt.png?scale=1&scaleIndex=0&w=2&h=1&v=cd7c25de181e6a77812020eb6e8679713\",\"league\":\"Hardcore Abyss\",\"id\":\"ee1bc0ca1d525b07ec6d806edb8c50423bd1d55995fa6a993a1384ec2a6833c0\",\"sockets\":[{\"group\":0,\"attr\":false,\"sColour\":\"A\"}],\"name\":\"<<set:MS>><<set:M>><<set:S>>Skull Twine\",\"typeLine\":\"Stygian Vise\",\"identified\":true,\"requirements\":[{\"name\":\"Level\",\"values\":[[\"54\",0]],\"displayMode\":0}],\"implicitMods\":[\"Has 1 Abyssal Socket\"],\"explicitMods\":[\"+59 to Armour\",\"+71 to maximum Life\",\"+28% to Fire Resistance\",\"+33% to Cold Resistance\",\"20% increased Stun and Block Recovery\"],\"frameType\":2,\"category\":{\"accessories\":[\"belt\"]},\"x\":22,\"y\":5,\"inventoryId\":\"Stash5\",\"socketedItems\":[{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":74,\"icon\":\"http:\\/\\/web.poecdn.com\\/image\\/Art\\/2DItems\\/Jewels\\/SearchingEye.png?scale=1&scaleIndex=0&w=1&h=1&v=1594a76f6cdc4a09e38ca58035d0ce873\",\"league\":\"Hardcore Abyss\",\"id\":\"c839921330a6d6c900eacf412b8145f17bf6608672a6e0dbb85349fc464d5a77\",\"abyssJewel\":true,\"name\":\"<<set:MS>><<set:M>><<set:S>>Ancient Stinger\",\"typeLine\":\"Searching Eye Jewel\",\"identified\":true,\"properties\":[{\"name\":\"Abyss\",\"values\":[],\"displayMode\":0}],\"requirements\":[{\"name\":\"Level\",\"values\":[[\"54\",0]],\"displayMode\":0}],\"explicitMods\":[\"5% increased Attack Speed\",\"+30 to maximum Life\",\"Adds 18 to 29 Cold Damage to Bow Attacks\"],\"descrText\":\"Place into an Abyssal Socket on an Item or into an allocated Jewel Socket on the Passive Skill Tree. Right click to remove from the Socket.\",\"frameType\":2,\"category\":{\"jewels\":[\"abyss\"]},\"socket\":0,\"colour\":false},{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":74,\"icon\":\"http:\\/\\/web.poecdn.com\\/image\\/Art\\/2DItems\\/Jewels\\/SearchingEye.png?scale=1&scaleIndex=0&w=1&h=1&v=1594a76f6cdc4a09e38ca58035d0ce873\",\"league\":\"Hardcore Abyss\",\"id\":\"c839921330a6d6c900eacf412b8145f17bf6608672a6e0dbb85349fc464d5a77\",\"abyssJewel\":true,\"name\":\"<<set:MS>><<set:M>><<set:S>>Ancient Stinger\",\"typeLine\":\"Searching Eye Jewel\",\"identified\":true,\"properties\":[{\"name\":\"Abyss\",\"values\":[],\"displayMode\":0}],\"requirements\":[{\"name\":\"Level\",\"values\":[[\"54\",0]],\"displayMode\":0}],\"explicitMods\":[\"5% increased Attack Speed\",\"+30 to maximum Life\",\"Adds 18 to 29 Cold Damage to Bow Attacks\"],\"descrText\":\"Place into an Abyssal Socket on an Item or into an allocated Jewel Socket on the Passive Skill Tree. Right click to remove from the Socket.\",\"frameType\":2,\"category\":{\"jewels\":[\"abyss\"]},\"socket\":0,\"colour\":false},{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":0,\"icon\":\"http:\\/\\/web.poecdn.com\\/image\\/Art\\/2DItems\\/Gems\\/Support\\/Pierce.png?scale=1&scaleIndex=0&w=1&h=1&v=3adf8484c5565e2f4b02dc1db98cd9db3\",\"support\":true,\"league\":\"Abyss\",\"id\":\"14aee51f2cd7759b3a738f7ff1407acbac6879e8bb97ae7dfb777ca3c153d3c8\",\"name\":\"\",\"typeLine\":\"Pierce Support\",\"identified\":true,\"note\":\"~price 4 chaos\",\"properties\":[{\"name\":\"Support, Projectile\",\"values\":[],\"displayMode\":0},{\"name\":\"Level\",\"values\":[[\"1\",0]],\"displayMode\":0,\"type\":5},{\"name\":\"Mana Multiplier\",\"values\":[[\"110%\",0]],\"displayMode\":0},{\"name\":\"Quality\",\"values\":[[\"+16%\",1]],\"displayMode\":0,\"type\":6}],\"additionalProperties\":[{\"name\":\"Experience\",\"values\":[[\"1\\/70\",0]],\"displayMode\":2,\"progress\":0.014285714365541935}],\"requirements\":[{\"name\":\"Level\",\"values\":[[\"1\",0]],\"displayMode\":0}],\"secDescrText\":\"Supports projectile skills.\",\"explicitMods\":[\"Projectiles from Supported Skills Pierce 2 additional Targets\",\"Supported Skills deal 8% increased Projectile Damage\"],\"descrText\":\"This is a Support Gem. It does not grant a bonus to your character, but to skills in sockets connected to it. Place into an item socket connected to a socket containing the Active Skill Gem you wish to augment. Right click to remove from a socket.\",\"frameType\":4,\"category\":\"gems\",\"x\":20,\"y\":12,\"inventoryId\":\"Stash3\"}]}",
        //        //    new JsonSerializerSettings
        //        //    {
        //        //        Converters = new JsonConverter[]
        //        //        {
        //        //            new ItemConverter()
        //        //        }
        //        //    });

        //        //var g = JsonConvert.DeserializeObject<SocketableItem>(
        //        //    "\"socketedItems\":[{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":0,\"icon\":\"http:\\/\\/web.poecdn.com\\/image\\/Art\\/2DItems\\/Gems\\/Support\\/Pierce.png?scale=1&scaleIndex=0&w=1&h=1&v=3adf8484c5565e2f4b02dc1db98cd9db3\",\"support\":true,\"league\":\"Abyss\",\"id\":\"14aee51f2cd7759b3a738f7ff1407acbac6879e8bb97ae7dfb777ca3c153d3c8\",\"name\":\"\",\"typeLine\":\"Pierce Support\",\"identified\":true,\"note\":\"~price 4 chaos\",\"properties\":[{\"name\":\"Support, Projectile\",\"values\":[],\"displayMode\":0},{\"name\":\"Level\",\"values\":[[\"1\",0]],\"displayMode\":0,\"type\":5},{\"name\":\"Mana Multiplier\",\"values\":[[\"110%\",0]],\"displayMode\":0},{\"name\":\"Quality\",\"values\":[[\"+16%\",1]],\"displayMode\":0,\"type\":6}],\"additionalProperties\":[{\"name\":\"Experience\",\"values\":[[\"1\\/70\",0]],\"displayMode\":2,\"progress\":0.014285714365541935}],\"requirements\":[{\"name\":\"Level\",\"values\":[[\"1\",0]],\"displayMode\":0}],\"secDescrText\":\"Supports projectile skills.\",\"explicitMods\":[\"Projectiles from Supported Skills Pierce 2 additional Targets\",\"Supported Skills deal 8% increased Projectile Damage\"],\"descrText\":\"This is a Support Gem. It does not grant a bonus to your character, but to skills in sockets connected to it. Place into an item socket connected to a socket containing the Active Skill Gem you wish to augment. Right click to remove from a socket.\",\"frameType\":4,\"category\":\"gems\",\"x\":20,\"y\":12,\"inventoryId\":\"Stash3\"}]", new SockatableConverter());


        //        var g = JsonConvert.DeserializeObject<Model.PublicStashAPI>(
        //            "{\"next_change_id\":null,\"stashes\":[{\"accountName\":null,\"lastCharacterName\":null,\"id\":null,\"stash\":null,\"stashType\":null,\"items\":[{\"verified\":false,\"w\":1,\"h\":1,\"ilvl\":84,\"icon\":\"http://web.poecdn.com/image/Art/2DItems/Belts/Shards/HarbingerBeltShard2.png?scale=1&scaleIndex=0&w=1&h=1&v=58e87397b6d39f7aeb0d80e0e91edbcb3\",\"league\":\"Standard\",\"id\":\"e57fd152759b3d341bd3e58d1186f4277bf59d36ca4e3a9a82a30e70cb5c2341\",\"name\":\"<<set:MS>><<set:M>><<set:S>>Second Piece of Time\",\"typeLine\":\"Cloth Belt Piece\",\"identified\":true,\"note\":\"~b/o 8 alch\",\"descrText\":\"This item will transform when correctly arranged with other items.\",\"frameType\":3,\"category\":{\"currency\":[\"piece\"]},\"x\":2,\"y\":2,\"inventoryId\":\"Stash12\"}],\"public\":false}]}",
        //            new ItemConverter());

        //        stopwatch.Stop();
        //        var time = stopwatch.Elapsed;
        //        stopwatch.Reset();

        //        //var ps = new PublicStashAPI {stashes = new[] {new Stash {items = new List<Item> {g}}}};
        //        //var json = JsonConvert.SerializeObject(ps);
        //        //var list2 = new List<Item>();
        //        //foreach (Stash stash in g.stashes)
        //        //{
        //        //    foreach (var item in stash.items)
        //        //    {
        //        //        if (item.typeLine == "stygian belt")
        //        //        {
        //        //        }
        //        //    }
        //        //}

        //        //var list = (from stash in g.stashes
        //        //    from item in stash.items
        //        //    where item.GetType() == typeof(UnspecifiedItem)
        //        //    select item).ToList();

        //        //var list = (from stash in g.stashes from item in stash.items where item.GetType() == typeof(UnspecifiedItem) select item).ToList();

        //        //if (list.Any())
        //        //{
        //        //}

        //        Thread.Sleep(10000);
        //    }
        //}
    }
}