using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class PublicStash
    {
        public string next_change_id { get; set; }
        public IEnumerable<Stash> stashes { get; set; }
    }
}
