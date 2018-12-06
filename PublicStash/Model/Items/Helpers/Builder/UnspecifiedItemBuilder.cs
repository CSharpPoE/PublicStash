using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal class UnspecifiedItemBuilder : IJsonBuilder<UnspecifiedItem>
    {
        private JObject JObject { get; set; }

        public IBuilder<JObject, UnspecifiedItem> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public UnspecifiedItem Build() => JObject.ToObject<UnspecifiedItem>();
    }
}