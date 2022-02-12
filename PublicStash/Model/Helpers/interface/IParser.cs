using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    internal interface IParser<in T>
    {
        string Parse(T obj);
    }

    internal interface IJsonParser : IParser<JObject>
    {
    }
}