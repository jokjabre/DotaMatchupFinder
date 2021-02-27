using DotaMatchupFinder.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Models
{
    public class KnownSearchModel
    {
        public Heroes Hero { get; set; }
        public Heroes Opponent { get; set; }
        public int Limit { get; set; } = 10;
        public int Tier { get; set; } = 60;
        public bool OnlyVictories { get; set; } = false;

        public bool OnlyProMatches { get; set; } = false;
    }
}
