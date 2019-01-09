using System.Collections.Generic;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Amulets
{
    public abstract class Amulet : Item
    {
    }

    public abstract class Talisman : Amulet
    {
    }

    #region Regular Amulets

    [Amulet("Coral Amulet")]
    public class CoralAmulet : Amulet
    {
    }

    [Amulet("Paua Amulet")]
    public class PauaAmulet : Amulet
    {
    }

    [Amulet("Amber Amulet")]
    public class AmberAmulet : Amulet
    {
    }

    [Amulet("Jade Amulet")]
    public class JadeAmulet : Amulet
    {
    }

    [Amulet("Lapis Amulet")]
    public class LapisAmulet : Amulet
    {
    }

    [Amulet("Gold Amulet")]
    public class GoldAmulet : Amulet
    {
    }

    [Amulet("Agate Amulet")]
    public class AgateAmulet : Amulet
    {
    }

    [Amulet("Citrine Amulet")]
    public class CitrineAmulet : Amulet
    {
    }

    [Amulet("Turquoise Amulet")]
    public class TurquoiseAmulet : Amulet
    {
    }

    [Amulet("Onyx Amulet")]
    public class OnyxAmulet : Amulet
    {
    }

    [Amulet("Marble Amulet")]
    public class MarbleAmulet : Amulet
    {
    }

    [Amulet("Blue Pearl Amulet")]
    public class BluePearlAmulet : Amulet
    {
    }

    #endregion

    #region Talisman

    [Talisman("Ashscale Talisman")]
    public class AshscaleTalisman : Talisman
    {
    }

    [Talisman("Avian Twins Talisman")]
    public class AvianTwinsTalisman : Talisman
    {
    }

    [Talisman("Black Maw Talisman")]
    public class BlackMawTalisman : Talisman, Socketable
    {
        public IEnumerable<Socket> Sockets { get; set; }
        public IEnumerable<Item> SocketedItems { get; set; }
    }

    [Talisman("Bonespire Talisman")]
    public class BonespireTalisman : Talisman
    {
    }

    [Talisman("Breakrib Talisman")]
    public class BreakribTalisman : Talisman
    {
    }

    [Talisman("Chrysalis Talisman")]
    public class ChrysalisTalisman : Talisman
    {
    }

    [Talisman("Clutching Talisman")]
    public class ClutchingTalisman : Talisman
    {
    }

    [Talisman("Deadhand Talisman")]
    public class DeadhandTalisman : Talisman
    {
    }

    [Talisman("Deep One Talisman")]
    public class DeepOneTalisman : Talisman
    {
    }

    [Talisman("Fangjaw Talisman")]
    public class FangjawTalisman : Talisman
    {
    }

    [Talisman("Greatwolf Talisman")]
    public class GreatwolfTalisman : Talisman
    {
    }

    [Talisman("Hexclaw Talisman")]
    public class HexclawTalisman : Talisman
    {
    }

    [Talisman("Horned Talisman")]
    public class HornedTalisman : Talisman
    {
    }

    [Talisman("Lone Antler Talisman")]
    public class LoneAntlerTalisman : Talisman
    {
    }

    [Talisman("Longtooth Talisman")]
    public class LongtoothTalisman : Talisman
    {
    }

    [Talisman("Mandible Talisman")]
    public class MandibleTalisman : Talisman
    {
    }

    [Talisman("Monkey Paw Talisman")]
    public class MonkeyPawTalisman : Talisman
    {
    }

    [Talisman("Primal Skull Talisman")]
    public class PrimalSkullTalisman : Talisman
    {
    }

    [Talisman("Rot Head Talisman")]
    public class RotHeadTalisman : Talisman
    {
    }

    [Talisman("Rotfeather Talisman")]
    public class RotfeatherTalisman : Talisman
    {
    }

    [Talisman("Spinefuse Talisman")]
    public class SpinefuseTalisman : Talisman
    {
    }

    [Talisman("Splitnewt Talisman")]
    public class SplitnewtTalisman : Talisman
    {
    }

    [Talisman("Three Hands Talisman")]
    public class ThreeHandsTalisman : Talisman
    {
    }

    [Talisman("Three Rat Talisman")]
    public class ThreeRatTalisman : Talisman
    {
    }

    [Talisman("Undying Flesh Talisman")]
    public class UndyingFleshTalisman : Talisman
    {
    }

    [Talisman("Wereclaw Talisman")]
    public class WereclawTalisman : Talisman
    {
    }

    [Talisman("Writhing Talisman")]
    public class WrithingTalisman : Talisman
    {
    }

    #endregion

    #region Disabled

    [Amulet("Jet Amulet")]
    public class JetAmulet : Amulet
    {
    }

    [Amulet("Ruby Amulet")]
    public class RubyAmulet : Amulet
    {
    }

    #endregion
}