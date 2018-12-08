using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;
using static Newtonsoft.Json.NullValueHandling;

namespace PathOfExile.Model.Items.Currencies.Delve
{
    public class Resonator : Currency
    {
        [JsonProperty("sockets")]
        public IEnumerable<Socket> Sockets { get; set; }

        [JsonProperty("socketedItems", NullValueHandling = Ignore)]
        [JsonConverter(typeof(ItemConverter))]
        public IEnumerable<Fossil> SocketedItems { get; set; }
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
