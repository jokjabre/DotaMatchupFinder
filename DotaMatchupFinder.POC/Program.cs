using DotaMatchupFinder.Core.Mappings;
using DotaMatchupFinder.Core.Models;
using DotaMatchupFinder.Core.Parsers;
using DotaMatchupFinder.Core.QueryBuilders;
using DotaMatchupFinder.Core.Wrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;

namespace DotaMatchupFinder.POC
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = null;
            while (hero == null)
            {
                Console.Write("Insert hero name:");
                var txt = Console.ReadLine();
                hero = HeroMappings.FindHeroByName(txt);
            }

            Hero opp = null;
            while (opp == null)
            {
                Console.Write("Insert opponent name:");
                var txt = Console.ReadLine();
                opp = HeroMappings.FindHeroByName(txt);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(string.Format("{0,-12} {1,-22} {2,-22} {3,-5}", "Match id", "Hero", "Opponent", "Result"));
            var result = KnownSearches.LaneMatchup(hero.NameEnum, opp.NameEnum, 20, 90).Result;

            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
        }

        private static void MakeHeroMap()
        {
            using WebClient client = new WebClient();
            using Stream stream = client.OpenRead("https://raw.githubusercontent.com/odota/dotaconstants/master/build/hero_names.json");
            using StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();

            string classCodeStart = 
 @"
private List<Hero> _heroes = new List<Hero>()
{

"
;
            StringBuilder classCodeMiddle = new StringBuilder();

            var Json = JsonConvert.DeserializeObject<JObject>(content);
            foreach (JProperty hero in Json.Children())
            {
                var id = hero.Value.Value<string>("id");
                var name = hero.Value.Value<string>("localized_name");
                classCodeMiddle.AppendLine($@"new Hero() {{ Id = {id}, Name = ""{name}""}},");
            }

            string classCodeEnd =
@"
}
;
";

            var result = classCodeStart + classCodeMiddle.ToString() + classCodeEnd;

            Console.WriteLine(result);
        }
    }
}
