using PathOfExile.Model.Internal;
using PathOfExile.Model.Items.Jewels.Abyss;

namespace PathOfExile.Model.Items.Jewels.Clusters
{
    public abstract class ClusterJewel : Jewel
    {
    }

    [ClusterJewel("Small Cluster Jewel")]
    public class SmallClusterJewel : ClusterJewel
    {
    }

    [ClusterJewel("Medium Cluster Jewel")]
    public class MediumClusterJewel : ClusterJewel
    {
    }

    [ClusterJewel("Large Cluster Jewel")]
    public class LargeClusterJewel : ClusterJewel
    {
    }
}