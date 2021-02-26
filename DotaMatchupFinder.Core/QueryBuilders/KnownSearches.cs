using DotaMatchupFinder.Core.Mappings;
using DotaMatchupFinder.Core.Models;
using DotaMatchupFinder.Core.Parsers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotaMatchupFinder.Core.QueryBuilders
{
    public class KnownSearches
    {
        public static async Task<List<BasicResultModel>> LaneMatchup(HeroEnum hero, HeroEnum opponent, int limit = 10, int tier = 10)
        {
            string query =
                $@"
SELECT    
public_matches.match_id,
public_matches.start_time,
((public_player_matches.player_slot < 128) = public_matches.radiant_win) win,
public_matches.avg_rank_tier,
public_player_matches.hero_id,
second_player.hero_id AS opponent_id
FROM public_matches
JOIN public_player_matches using(match_id)
JOIN public_player_matches second_player using(match_id)
WHERE TRUE
AND avg_rank_tier > {tier}
AND public_matches.start_time >= (extract(epoch from now()) - 86400)
AND public_player_matches.hero_id = {HeroMappings.GetHeroId(hero)}
AND second_player.hero_id = {HeroMappings.GetHeroId(opponent)}
AND ((public_player_matches.player_slot < 128 AND second_player.player_slot > 127) OR (public_player_matches.player_slot > 127 AND second_player.player_slot < 128))
ORDER BY public_matches.match_id DESC
LIMIT {limit}
";

            return await (new JsonParser().ParseQuery<BasicResultModel>(query));
        }

        public static async Task<List<BasicResultModel>> LaneMatchup(KnownSearchModel model)
        {
            return await LaneMatchup(model.Hero, model.Opponent, model.Limit, model.Tier);
        }

        public static async Task<List<BasicResultModel>> LaneMatchupPro(HeroEnum hero, HeroEnum opponent, int limit = 10, int tier = 60)
        {
            string query =
                $@"
SELECT    
public_matches.match_id,
public_matches.start_time,
((public_player_matches.player_slot < 128) = public_matches.radiant_win) win,
public_matches.avg_rank_tier,
public_player_matches.hero_id,
second_player.hero_id AS opponent_id
FROM public_matches
JOIN public_player_matches using(match_id)
JOIN public_player_matches second_player using(match_id)
WHERE TRUE
AND avg_rank_tier > {tier}
AND public_matches.start_time >= (extract(epoch from now()) - 86400)
AND public_player_matches.hero_id = {HeroMappings.GetHeroId(hero)}
AND second_player.hero_id = {HeroMappings.GetHeroId(opponent)}
AND ((public_player_matches.player_slot < 128 AND second_player.player_slot > 127) OR (public_player_matches.player_slot > 127 AND second_player.player_slot < 128))
ORDER BY public_matches.match_id DESC
LIMIT {limit}
";

            return await (new JsonParser().ParseQuery<BasicResultModel>(query));
        }
    }
}



