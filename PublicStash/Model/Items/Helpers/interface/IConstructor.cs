using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal interface IConstructor<in In, out Out>
    {
        Out ConstructFrom(In obj);
    }

    internal interface IJsonConstructor : IConstructor<JObject, Item>
    {
    }
}
