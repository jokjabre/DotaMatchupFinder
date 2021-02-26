using DotaMatchupFinder.Core.Mappings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Models
{
    public class BasicResultModel
    {
        [JsonProperty("match_id")]
        public double MatchId { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonIgnore]
        public string HeroName => HeroMappings.GetHeroName(HeroId);


        [JsonProperty("opponent_id")]
        public int OpponentId { get; set; }

        [JsonIgnore]
        public string OpponentName => HeroMappings.GetHeroName(OpponentId);

        [JsonProperty("win")]
        public bool Win { get; set; }


        public override string ToString()
        {
            
            return string.Format("{0,-12} {1,-22} {2,-22} {3,-5}", MatchId.ToString(), HeroName, OpponentName, Win ? "Win" : "Loss");
        }
    }
}
