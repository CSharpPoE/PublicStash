using System.Collections.Generic;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Rings
{
    public abstract class Ring : Item
    {
    }

    [Ring("Unset Ring")]
    public class UnsetRing : Ring, Socketable
    {
        public IEnumerable<Socket> Sockets { get; set; }
        public IEnumerable<Item> SocketedItems { get; set; }
    }

    [Ring("Breach Ring")]
    public class BreachRing : Ring
    {
    }

    [Ring("Coral Ring")]
    public class CoralRing : Ring
    {
    }

    [Ring("Iron Ring")]
    public class IronRing : Ring
    {
    }

    [Ring("Paua Ring")]
    public class PauaRing : Ring
    {
    }

    [Ring("Sapphire Ring")]
    public class SapphireRing : Ring
    {
    }

    [Ring("Topaz Ring")]
    public class TopazRing : Ring
    {
    }

    [Ring("Ruby Ring")]
    public class RubyRing : Ring
    {
    }

    [Ring("Diamond Ring")]
    public class DiamondRing : Ring
    {
    }

    [Ring("Gold Ring")]
    public class GoldRing : Ring
    {
    }

    [Ring("Moonstone Ring")]
    public class MoonstoneRing : Ring
    {
    }

    [Ring("Two-Stone Ring")]
    public class TwoStoneRing : Ring
    {
    }

    [Ring("Amethyst Ring")]
    public class AmethystRing : Ring
    {
    }

    [Ring("Prismatic Ring")]
    public class PrismaticRing : Ring
    {
    }

    [Ring("Opal Ring")]
    public class OpalRing : Ring
    {
    }

    [Ring("Steel Ring")]
    public class SteelRing : Ring
    {
    }

    [Ring("Golden Hoop")]
    public class GoldenHoop : Ring
    {
    }

    [Ring("Jet Ring")]
    public class JetRing : Ring
    {
    }
}