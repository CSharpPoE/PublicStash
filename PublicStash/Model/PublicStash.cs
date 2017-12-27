using System.Collections.Generic;

namespace PublicStash.Model
{
    public class PublicStash
    {
        public string next_change_id { get; set; }
        public IEnumerable<Stash> stashes { get; set; }
    }
}
