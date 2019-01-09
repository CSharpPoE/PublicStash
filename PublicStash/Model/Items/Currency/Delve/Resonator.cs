using System.Collections.Generic;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Currencies.Delve
{
    public abstract class Resonator : Currency, Socketable
    {
        public IEnumerable<Socket> Sockets { get; set; }
        public IEnumerable<Item> SocketedItems { get; set; }
    }

    [Resonator("Potent Alchemical Resonator")]
    public class PotentAlchemicalResonator : Resonator
    {
    }

    [Resonator("Potent Chaotic Resonator")]
    public class PotentChaoticResonator : Resonator
    {
    }

    [Resonator("Powerful Alchemical Resonator")]
    public class PowerfulAlchemicalResonator : Resonator
    {
    }

    [Resonator("Powerful Chaotic Resonator")]
    public class PowerfulChaoticResonator : Resonator
    {
    }

    [Resonator("Prime Alchemical Resonator")]
    public class PrimeAlchemicalResonator : Resonator
    {
    }

    [Resonator("Prime Chaotic Resonator")]
    public class PrimeChaoticResonator : Resonator
    {
    }

    [Resonator("Primitive Alchemical Resonator")]
    public class PrimitiveAlchemicalResonator : Resonator
    {
    }

    [Resonator("Primitive Chaotic Resonator")]
    public class PrimitiveChaoticResonator : Resonator
    {
    }
}