using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal interface IBuilder<in In, out Out>
    {
        IBuilder<In, Out> For(In obj);
        Out Build();
    }

    internal interface IJsonBuilder<out T> : IBuilder<JObject, T> where T : Item
    {
    }
}
