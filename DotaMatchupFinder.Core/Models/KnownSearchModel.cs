using DotaMatchupFinder.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Models
{
    public class KnownSearchModel
    {
        public HeroEnum Hero { get; set; }
        public HeroEnum Opponent { get; set; }
        public int Limit { get; set; } = 10;
        public int Tier { get; set; } = 10;
    }
}
