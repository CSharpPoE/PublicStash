using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Items
{
    internal interface IConstructor<in In, out Out>
    {
        IConstructor<In, Out> For(In obj);
        Out Construct();
    }

    internal interface IJsonConstructor : IConstructor<JObject, Item>
    {
    }
}
