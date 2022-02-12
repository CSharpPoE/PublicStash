using PathOfExile.Model.Items.Maps;

namespace PathOfExile.Model.Internal
{
    internal class MapBuilder : TBuilder<Map>
    {
        public MapBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<MapAttribute>())
        {
        }
    }
}