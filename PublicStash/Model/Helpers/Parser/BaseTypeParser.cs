using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    public class BaseTypeParser : IParser<JObject>
    {
        public virtual string Parse(JObject obj)
        {
            return obj["baseType"].ToObject<string>();
        }
    }
}