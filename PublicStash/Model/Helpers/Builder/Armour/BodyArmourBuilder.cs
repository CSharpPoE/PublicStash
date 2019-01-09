using PathOfExile.Model.Items.Armours.BodyArmours;

namespace PathOfExile.Model.Internal
{
    internal class BodyArmourBuilder : TBuilder<BodyArmour>
    {
        public BodyArmourBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<BodyArmourAttribute>())
        {
        }
    }
}