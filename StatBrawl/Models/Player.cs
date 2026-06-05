using System.Collections.Generic;

namespace StatBrawl.Models
{
    public class Player
    {
        public string name { get; set; }
        public int trophies { get; set; }
        public int highestTrophies { get; set; }
        public List<Brawler> brawlers { get; set; }
    }
}
