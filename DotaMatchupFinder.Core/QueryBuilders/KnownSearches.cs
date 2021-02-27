using DotaMatchupFinder.Core.Mappings;
using DotaMatchupFinder.Core.Models;
using DotaMatchupFinder.Core.Parsers;
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DotaMatchupFinder.Core.QueryBuilders
{
    public class KnownSearches
    {

        public static async Task<List<BasicResultModel>> LaneMatchup(KnownSearchModel model)
        {
            string query = GetQuery(model);

            return await (new JsonParser().ParseQuery<BasicResultModel>(query));
        }

        private static string GetQuery(KnownSearchModel model)
        {
            int limit = (model.Limit < 0) ? 10 : model.Limit;
            int tier = (model.Tier < 0) ? 60 : model.Tier;

            string query = string.Empty;
            string result = string.Empty;

            if (model.OnlyProMatches)
            {

            }
            else
            {
                query = model.OnlyVictories ? string.Empty : Queries.PubQuery;

                result = string.Format(query, 
                    tier, 
                    HeroMappings.GetHeroId(model.Hero), 
                    HeroMappings.GetHeroId(model.Opponent), 
                    limit);
            }

            return result;
        }
    }
}



