using System.Collections.Generic;

namespace PoEPublicStash.Model
{
    public class PublicStash
    {
        public string next_change_id { get; set; }
        public IEnumerable<Stash> stashes { get; set; }
    }
}
