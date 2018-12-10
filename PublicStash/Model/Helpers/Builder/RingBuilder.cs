using PathOfExile.Model.Items.Rings;

namespace PathOfExile.Model.Internal
{
    internal class RingBuilder : TBuilder<Ring>
    {
        public RingBuilder() : base(new TypeLineParser(), AttributeHelper.Index<RingAttribute>())
        {
        }
    }
}