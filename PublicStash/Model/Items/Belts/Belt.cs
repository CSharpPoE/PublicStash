using System.Collections.Generic;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Belts
{
    public abstract class Belt : Item
    {
    }

    [Belt("Chain Belt")]
    public class ChainBelt : Belt
    {
    }

    [Belt("Rustic Sash")]
    public class RusticSash : Belt
    {
    }

    [Belt("Stygian Vise")]
    public class StygianVise : Belt, Socketable
    {
        public IEnumerable<Socket> Sockets { get; set; }
        public IEnumerable<Item> SocketedItems { get; set; }
    }

    [Belt("Heavy Belt")]
    public class HeavyBelt : Belt
    {
    }

    [Belt("Leather Belt")]
    public class LeatherBelt : Belt
    {
    }

    [Belt("Cloth Belt")]
    public class ClothBelt : Belt
    {
    }

    [Belt("Studded Belt")]
    public class StuddedBelt : Belt
    {
    }

    [Belt("Vanguard Belt")]
    public class VanguardBelt : Belt
    {
    }

    [Belt("Crystal Belt")]
    public class CrystalBelt : Belt
    {
    }
}