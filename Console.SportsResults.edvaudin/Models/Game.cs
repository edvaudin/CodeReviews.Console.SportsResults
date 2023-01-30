using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsResults
{
    internal class Game
    {
        public string WinningTeam { get; set; }
        public string LosingTeam { get; set; }
        public int WinningScore { get; set; }
        public int LosingScore { get; set; }

        public string HighestPointScorer { get; set; }
        public int HighestPlayerPoints { get; set; }

        public string MostTotalRebounder { get; set; }
        public int MostPlayerTotalRebounds { get; set; }
        
    }
}
