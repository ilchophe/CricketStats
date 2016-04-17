using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketStats.Models;

namespace CricketStats.ViewModels
{
    class MatchViewModel
    {
        public Match MatchPlayed { get; set; }

        public List<BattingInn> InningsBat { get; set; }

        public List<BowlingInn> InningsBowl { get; set; }



    }
}
