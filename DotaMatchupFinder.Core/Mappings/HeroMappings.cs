using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DotaMatchupFinder.Core.Mappings
{
    public class HeroMappings
    {
        private static List<Hero> _heroes = new List<Hero>()
        {
            new Hero() { Id = 1,   NameEnum = HeroEnum.Anti_Mage,  Name = "Anti-Mage"},
            new Hero() { Id = 2,   NameEnum = HeroEnum.Axe,  Name = "Axe"},
            new Hero() { Id = 3,   NameEnum = HeroEnum.Bane,  Name = "Bane"},
            new Hero() { Id = 4,   NameEnum = HeroEnum.Bloodseeker,  Name = "Bloodseeker"},
            new Hero() { Id = 5,   NameEnum = HeroEnum.Crystal_Maiden,  Name = "Crystal Maiden"},
            new Hero() { Id = 6,   NameEnum = HeroEnum.Drow_Ranger,  Name = "Drow Ranger"},
            new Hero() { Id = 7,   NameEnum = HeroEnum.Earthshaker,  Name = "Earthshaker"},
            new Hero() { Id = 8,   NameEnum = HeroEnum.Juggernaut,  Name = "Juggernaut"},
            new Hero() { Id = 9,   NameEnum = HeroEnum.Mirana,  Name = "Mirana"},
            new Hero() { Id = 10,  NameEnum = HeroEnum.Morphling,  Name = "Morphling"},
            new Hero() { Id = 11,  NameEnum = HeroEnum.Shadow_Fiend,  Name = "Shadow Fiend"},
            new Hero() { Id = 12,  NameEnum = HeroEnum.Phantom_Lancer,  Name = "Phantom Lancer"},
            new Hero() { Id = 13,  NameEnum = HeroEnum.Puck,  Name = "Puck"},
            new Hero() { Id = 14,  NameEnum = HeroEnum.Pudge,  Name = "Pudge"},
            new Hero() { Id = 15,  NameEnum = HeroEnum.Razor,  Name = "Razor"},
            new Hero() { Id = 16,  NameEnum = HeroEnum.Sand_King,  Name = "Sand King"},
            new Hero() { Id = 17,  NameEnum = HeroEnum.Storm_Spirit,  Name = "Storm Spirit"},
            new Hero() { Id = 18,  NameEnum = HeroEnum.Sven,  Name = "Sven"},
            new Hero() { Id = 19,  NameEnum = HeroEnum.Tiny,  Name = "Tiny"},
            new Hero() { Id = 20,  NameEnum = HeroEnum.Vengeful_Spirit,  Name = "Vengeful Spirit"},
            new Hero() { Id = 21,  NameEnum = HeroEnum.Windranger,  Name = "Windranger"},
            new Hero() { Id = 22,  NameEnum = HeroEnum.Zeus,  Name = "Zeus"},
            new Hero() { Id = 23,  NameEnum = HeroEnum.Kunkka,  Name = "Kunkka"},
            new Hero() { Id = 25,  NameEnum = HeroEnum.Lina,  Name = "Lina"},
            new Hero() { Id = 26,  NameEnum = HeroEnum.Lion,  Name = "Lion"},
            new Hero() { Id = 27,  NameEnum = HeroEnum.Shadow_Shaman,  Name = "Shadow Shaman"},
            new Hero() { Id = 28,  NameEnum = HeroEnum.Slardar,  Name = "Slardar"},
            new Hero() { Id = 29,  NameEnum = HeroEnum.Tidehunter,  Name = "Tidehunter"},
            new Hero() { Id = 30,  NameEnum = HeroEnum.Witch_Doctor,  Name = "Witch Doctor"},
            new Hero() { Id = 31,  NameEnum = HeroEnum.Lich,  Name = "Lich"},
            new Hero() { Id = 32,  NameEnum = HeroEnum.Riki,  Name = "Riki"},
            new Hero() { Id = 33,  NameEnum = HeroEnum.Enigma,  Name = "Enigma"},
            new Hero() { Id = 34,  NameEnum = HeroEnum.Tinker,  Name = "Tinker"},
            new Hero() { Id = 35,  NameEnum = HeroEnum.Sniper,  Name = "Sniper"},
            new Hero() { Id = 36,  NameEnum = HeroEnum.Necrophos,  Name = "Necrophos"},
            new Hero() { Id = 37,  NameEnum = HeroEnum.Warlock,  Name = "Warlock"},
            new Hero() { Id = 38,  NameEnum = HeroEnum.Beastmaster,  Name = "Beastmaster"},
            new Hero() { Id = 39,  NameEnum = HeroEnum.Queen_of_Pain,  Name = "Queen of Pain"},
            new Hero() { Id = 40,  NameEnum = HeroEnum.Venomancer,  Name = "Venomancer"},
            new Hero() { Id = 41,  NameEnum = HeroEnum.Faceless_Void,  Name = "Faceless Void"},
            new Hero() { Id = 42,  NameEnum = HeroEnum.Wraith_King,  Name = "Wraith King"},
            new Hero() { Id = 43,  NameEnum = HeroEnum.Death_Prophet,  Name = "Death Prophet"},
            new Hero() { Id = 44,  NameEnum = HeroEnum.Phantom_Assassin,  Name = "Phantom Assassin"},
            new Hero() { Id = 45,  NameEnum = HeroEnum.Pugna,  Name = "Pugna"},
            new Hero() { Id = 46,  NameEnum = HeroEnum.Templar_Assassin,  Name = "Templar Assassin"},
            new Hero() { Id = 47,  NameEnum = HeroEnum.Viper,  Name = "Viper"},
            new Hero() { Id = 48,  NameEnum = HeroEnum.Luna,  Name = "Luna"},
            new Hero() { Id = 49,  NameEnum = HeroEnum.Dragon_Knight,  Name = "Dragon Knight"},
            new Hero() { Id = 50,  NameEnum = HeroEnum.Dazzle,  Name = "Dazzle"},
            new Hero() { Id = 51,  NameEnum = HeroEnum.Clockwerk,  Name = "Clockwerk"},
            new Hero() { Id = 52,  NameEnum = HeroEnum.Leshrac,  Name = "Leshrac"},
            new Hero() { Id = 53,  NameEnum = HeroEnum.Natures_Prophet,  Name = "Nature's Prophet"},
            new Hero() { Id = 54,  NameEnum = HeroEnum.Lifestealer,  Name = "Lifestealer"},
            new Hero() { Id = 55,  NameEnum = HeroEnum.Dark_Seer,  Name = "Dark Seer"},
            new Hero() { Id = 56,  NameEnum = HeroEnum.Clinkz,  Name = "Clinkz"},
            new Hero() { Id = 57,  NameEnum = HeroEnum.Omniknight,  Name = "Omniknight"},
            new Hero() { Id = 58,  NameEnum = HeroEnum.Enchantress,  Name = "Enchantress"},
            new Hero() { Id = 59,  NameEnum = HeroEnum.Huskar,  Name = "Huskar"},
            new Hero() { Id = 60,  NameEnum = HeroEnum.Night_Stalker,  Name = "Night Stalker"},
            new Hero() { Id = 61,  NameEnum = HeroEnum.Broodmother,  Name = "Broodmother"},
            new Hero() { Id = 62,  NameEnum = HeroEnum.Bounty_Hunter,  Name = "Bounty Hunter"},
            new Hero() { Id = 63,  NameEnum = HeroEnum.Weaver,  Name = "Weaver"},
            new Hero() { Id = 64,  NameEnum = HeroEnum.Jakiro,  Name = "Jakiro"},
            new Hero() { Id = 65,  NameEnum = HeroEnum.Batrider,  Name = "Batrider"},
            new Hero() { Id = 66,  NameEnum = HeroEnum.Chen,  Name = "Chen"},
            new Hero() { Id = 67,  NameEnum = HeroEnum.Spectre,  Name = "Spectre"},
            new Hero() { Id = 68,  NameEnum = HeroEnum.Ancient_Apparition,  Name = "Ancient Apparition"},
            new Hero() { Id = 69,  NameEnum = HeroEnum.Doom,  Name = "Doom"},
            new Hero() { Id = 70,  NameEnum = HeroEnum.Ursa,  Name = "Ursa"},
            new Hero() { Id = 71,  NameEnum = HeroEnum.Spirit_Breaker,  Name = "Spirit Breaker"},
            new Hero() { Id = 72,  NameEnum = HeroEnum.Gyrocopter,  Name = "Gyrocopter"},
            new Hero() { Id = 73,  NameEnum = HeroEnum.Alchemist,  Name = "Alchemist"},
            new Hero() { Id = 74,  NameEnum = HeroEnum.Invoker,  Name = "Invoker"},
            new Hero() { Id = 75,  NameEnum = HeroEnum.Silencer,  Name = "Silencer"},
            new Hero() { Id = 76,  NameEnum = HeroEnum.Outworld_Devourer,  Name = "Outworld Devourer"},
            new Hero() { Id = 77,  NameEnum = HeroEnum.Lycan,  Name = "Lycan"},
            new Hero() { Id = 78,  NameEnum = HeroEnum.Brewmaster,  Name = "Brewmaster"},
            new Hero() { Id = 79,  NameEnum = HeroEnum.Shadow_Demon,  Name = "Shadow Demon"},
            new Hero() { Id = 80,  NameEnum = HeroEnum.Lone_Druid,  Name = "Lone Druid"},
            new Hero() { Id = 81,  NameEnum = HeroEnum.Chaos_Knight,  Name = "Chaos Knight"},
            new Hero() { Id = 82,  NameEnum = HeroEnum.Meepo,  Name = "Meepo"},
            new Hero() { Id = 83,  NameEnum = HeroEnum.Treant_Protector,  Name = "Treant Protector"},
            new Hero() { Id = 84,  NameEnum = HeroEnum.Ogre_Magi,  Name = "Ogre Magi"},
            new Hero() { Id = 85,  NameEnum = HeroEnum.Undying,  Name = "Undying"},
            new Hero() { Id = 86,  NameEnum = HeroEnum.Rubick,  Name = "Rubick"},
            new Hero() { Id = 87,  NameEnum = HeroEnum.Disruptor,  Name = "Disruptor"},
            new Hero() { Id = 88,  NameEnum = HeroEnum.Nyx_Assassin,  Name = "Nyx Assassin"},
            new Hero() { Id = 89,  NameEnum = HeroEnum.Naga_Siren,  Name = "Naga Siren"},
            new Hero() { Id = 90,  NameEnum = HeroEnum.Keeper_of_the_Light,  Name = "Keeper of the Light"},
            new Hero() { Id = 91,  NameEnum = HeroEnum.Io,  Name = "Io"},
            new Hero() { Id = 92,  NameEnum = HeroEnum.Visage,  Name = "Visage"},
            new Hero() { Id = 93,  NameEnum = HeroEnum.Slark,  Name = "Slark"},
            new Hero() { Id = 94,  NameEnum = HeroEnum.Medusa,  Name = "Medusa"},
            new Hero() { Id = 95,  NameEnum = HeroEnum.Troll_Warlord,  Name = "Troll Warlord"},
            new Hero() { Id = 96,  NameEnum = HeroEnum.Centaur_Warrunner,  Name = "Centaur Warrunner"},
            new Hero() { Id = 97,  NameEnum = HeroEnum.Magnus,  Name = "Magnus"},
            new Hero() { Id = 98,  NameEnum = HeroEnum.Timbersaw,  Name = "Timbersaw"},
            new Hero() { Id = 99,  NameEnum = HeroEnum.Bristleback,  Name = "Bristleback"},
            new Hero() { Id = 100, NameEnum = HeroEnum.Tusk,  Name = "Tusk"},
            new Hero() { Id = 101, NameEnum = HeroEnum.Skywrath_Mage,  Name = "Skywrath Mage"},
            new Hero() { Id = 102, NameEnum = HeroEnum.Abaddon,  Name = "Abaddon"},
            new Hero() { Id = 103, NameEnum = HeroEnum.Elder_Titan,  Name = "Elder Titan"},
            new Hero() { Id = 104, NameEnum = HeroEnum.Legion_Commander,  Name = "Legion Commander"},
            new Hero() { Id = 105, NameEnum = HeroEnum.Techies,  Name = "Techies"},
            new Hero() { Id = 106, NameEnum = HeroEnum.Ember_Spirit,  Name = "Ember Spirit"},
            new Hero() { Id = 107, NameEnum = HeroEnum.Earth_Spirit,  Name = "Earth Spirit"},
            new Hero() { Id = 108, NameEnum = HeroEnum.Underlord,  Name = "Underlord"},
            new Hero() { Id = 109, NameEnum = HeroEnum.Terrorblade,  Name = "Terrorblade"},
            new Hero() { Id = 110, NameEnum = HeroEnum.Phoenix,  Name = "Phoenix"},
            new Hero() { Id = 111, NameEnum = HeroEnum.Oracle,  Name = "Oracle"},
            new Hero() { Id = 112, NameEnum = HeroEnum.Winter_Wyvern,  Name = "Winter Wyvern"},
            new Hero() { Id = 113, NameEnum = HeroEnum.Arc_Warden,  Name = "Arc Warden"},
            new Hero() { Id = 114, NameEnum = HeroEnum.Monkey_King,  Name = "Monkey King"},
            new Hero() { Id = 119, NameEnum = HeroEnum.Dark_Willow,  Name = "Dark Willow"},
            new Hero() { Id = 120, NameEnum = HeroEnum.Pangolier,  Name = "Pangolier"},
            new Hero() { Id = 121, NameEnum = HeroEnum.Grimstroke,  Name = "Grimstroke"},
            new Hero() { Id = 123, NameEnum = HeroEnum.Hoodwink,  Name = "Hoodwink"},
            new Hero() { Id = 126, NameEnum = HeroEnum.Void_Spirit,  Name = "Void Spirit"},
            new Hero() { Id = 128, NameEnum = HeroEnum.Snapfire,  Name = "Snapfire"},
            new Hero() { Id = 129, NameEnum = HeroEnum.Mars,  Name = "Mars"},
        };

        public static List<Hero> GetHeroesMap() => _heroes;

        public static Hero GetHero(int id) =>
            _heroes.FirstOrDefault(h => h.Id == id);

        public static string GetHeroName(int id) => 
            GetHero(id)?.Name ?? "Unknown";

        public static Hero GetHero(HeroEnum nameEnum) =>
            _heroes.FirstOrDefault(h => h.NameEnum == nameEnum);

        public static string GetHeroName(HeroEnum nameEnum) =>
            GetHero(nameEnum)?.Name ?? "Unknown";

        public static int GetHeroId(HeroEnum nameEnum) =>
            GetHero(nameEnum)?.Id ?? 0;

        public static Hero FindHeroByName(string name) =>
            _heroes.FirstOrDefault(h => h.Name == name);
    }
}
