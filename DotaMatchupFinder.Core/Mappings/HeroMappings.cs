using DotaMatchupFinder.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DotaMatchupFinder.Core.Mappings
{
    public class HeroMappings
    {
        private static List<HeroModel> _heroes = new List<HeroModel>()
        {
            new HeroModel() { Id = 1,   NameEnum = Heroes.Anti_Mage,  Name = "Anti-Mage"},
            new HeroModel() { Id = 2,   NameEnum = Heroes.Axe,  Name = "Axe"},
            new HeroModel() { Id = 3,   NameEnum = Heroes.Bane,  Name = "Bane"},
            new HeroModel() { Id = 4,   NameEnum = Heroes.Bloodseeker,  Name = "Bloodseeker"},
            new HeroModel() { Id = 5,   NameEnum = Heroes.Crystal_Maiden,  Name = "Crystal Maiden"},
            new HeroModel() { Id = 6,   NameEnum = Heroes.Drow_Ranger,  Name = "Drow Ranger"},
            new HeroModel() { Id = 7,   NameEnum = Heroes.Earthshaker,  Name = "Earthshaker"},
            new HeroModel() { Id = 8,   NameEnum = Heroes.Juggernaut,  Name = "Juggernaut"},
            new HeroModel() { Id = 9,   NameEnum = Heroes.Mirana,  Name = "Mirana"},
            new HeroModel() { Id = 10,  NameEnum = Heroes.Morphling,  Name = "Morphling"},
            new HeroModel() { Id = 11,  NameEnum = Heroes.Shadow_Fiend,  Name = "Shadow Fiend"},
            new HeroModel() { Id = 12,  NameEnum = Heroes.Phantom_Lancer,  Name = "Phantom Lancer"},
            new HeroModel() { Id = 13,  NameEnum = Heroes.Puck,  Name = "Puck"},
            new HeroModel() { Id = 14,  NameEnum = Heroes.Pudge,  Name = "Pudge"},
            new HeroModel() { Id = 15,  NameEnum = Heroes.Razor,  Name = "Razor"},
            new HeroModel() { Id = 16,  NameEnum = Heroes.Sand_King,  Name = "Sand King"},
            new HeroModel() { Id = 17,  NameEnum = Heroes.Storm_Spirit,  Name = "Storm Spirit"},
            new HeroModel() { Id = 18,  NameEnum = Heroes.Sven,  Name = "Sven"},
            new HeroModel() { Id = 19,  NameEnum = Heroes.Tiny,  Name = "Tiny"},
            new HeroModel() { Id = 20,  NameEnum = Heroes.Vengeful_Spirit,  Name = "Vengeful Spirit"},
            new HeroModel() { Id = 21,  NameEnum = Heroes.Windranger,  Name = "Windranger"},
            new HeroModel() { Id = 22,  NameEnum = Heroes.Zeus,  Name = "Zeus"},
            new HeroModel() { Id = 23,  NameEnum = Heroes.Kunkka,  Name = "Kunkka"},
            new HeroModel() { Id = 25,  NameEnum = Heroes.Lina,  Name = "Lina"},
            new HeroModel() { Id = 26,  NameEnum = Heroes.Lion,  Name = "Lion"},
            new HeroModel() { Id = 27,  NameEnum = Heroes.Shadow_Shaman,  Name = "Shadow Shaman"},
            new HeroModel() { Id = 28,  NameEnum = Heroes.Slardar,  Name = "Slardar"},
            new HeroModel() { Id = 29,  NameEnum = Heroes.Tidehunter,  Name = "Tidehunter"},
            new HeroModel() { Id = 30,  NameEnum = Heroes.Witch_Doctor,  Name = "Witch Doctor"},
            new HeroModel() { Id = 31,  NameEnum = Heroes.Lich,  Name = "Lich"},
            new HeroModel() { Id = 32,  NameEnum = Heroes.Riki,  Name = "Riki"},
            new HeroModel() { Id = 33,  NameEnum = Heroes.Enigma,  Name = "Enigma"},
            new HeroModel() { Id = 34,  NameEnum = Heroes.Tinker,  Name = "Tinker"},
            new HeroModel() { Id = 35,  NameEnum = Heroes.Sniper,  Name = "Sniper"},
            new HeroModel() { Id = 36,  NameEnum = Heroes.Necrophos,  Name = "Necrophos"},
            new HeroModel() { Id = 37,  NameEnum = Heroes.Warlock,  Name = "Warlock"},
            new HeroModel() { Id = 38,  NameEnum = Heroes.Beastmaster,  Name = "Beastmaster"},
            new HeroModel() { Id = 39,  NameEnum = Heroes.Queen_of_Pain,  Name = "Queen of Pain"},
            new HeroModel() { Id = 40,  NameEnum = Heroes.Venomancer,  Name = "Venomancer"},
            new HeroModel() { Id = 41,  NameEnum = Heroes.Faceless_Void,  Name = "Faceless Void"},
            new HeroModel() { Id = 42,  NameEnum = Heroes.Wraith_King,  Name = "Wraith King"},
            new HeroModel() { Id = 43,  NameEnum = Heroes.Death_Prophet,  Name = "Death Prophet"},
            new HeroModel() { Id = 44,  NameEnum = Heroes.Phantom_Assassin,  Name = "Phantom Assassin"},
            new HeroModel() { Id = 45,  NameEnum = Heroes.Pugna,  Name = "Pugna"},
            new HeroModel() { Id = 46,  NameEnum = Heroes.Templar_Assassin,  Name = "Templar Assassin"},
            new HeroModel() { Id = 47,  NameEnum = Heroes.Viper,  Name = "Viper"},
            new HeroModel() { Id = 48,  NameEnum = Heroes.Luna,  Name = "Luna"},
            new HeroModel() { Id = 49,  NameEnum = Heroes.Dragon_Knight,  Name = "Dragon Knight"},
            new HeroModel() { Id = 50,  NameEnum = Heroes.Dazzle,  Name = "Dazzle"},
            new HeroModel() { Id = 51,  NameEnum = Heroes.Clockwerk,  Name = "Clockwerk"},
            new HeroModel() { Id = 52,  NameEnum = Heroes.Leshrac,  Name = "Leshrac"},
            new HeroModel() { Id = 53,  NameEnum = Heroes.Natures_Prophet,  Name = "Nature's Prophet"},
            new HeroModel() { Id = 54,  NameEnum = Heroes.Lifestealer,  Name = "Lifestealer"},
            new HeroModel() { Id = 55,  NameEnum = Heroes.Dark_Seer,  Name = "Dark Seer"},
            new HeroModel() { Id = 56,  NameEnum = Heroes.Clinkz,  Name = "Clinkz"},
            new HeroModel() { Id = 57,  NameEnum = Heroes.Omniknight,  Name = "Omniknight"},
            new HeroModel() { Id = 58,  NameEnum = Heroes.Enchantress,  Name = "Enchantress"},
            new HeroModel() { Id = 59,  NameEnum = Heroes.Huskar,  Name = "Huskar"},
            new HeroModel() { Id = 60,  NameEnum = Heroes.Night_Stalker,  Name = "Night Stalker"},
            new HeroModel() { Id = 61,  NameEnum = Heroes.Broodmother,  Name = "Broodmother"},
            new HeroModel() { Id = 62,  NameEnum = Heroes.Bounty_Hunter,  Name = "Bounty Hunter"},
            new HeroModel() { Id = 63,  NameEnum = Heroes.Weaver,  Name = "Weaver"},
            new HeroModel() { Id = 64,  NameEnum = Heroes.Jakiro,  Name = "Jakiro"},
            new HeroModel() { Id = 65,  NameEnum = Heroes.Batrider,  Name = "Batrider"},
            new HeroModel() { Id = 66,  NameEnum = Heroes.Chen,  Name = "Chen"},
            new HeroModel() { Id = 67,  NameEnum = Heroes.Spectre,  Name = "Spectre"},
            new HeroModel() { Id = 68,  NameEnum = Heroes.Ancient_Apparition,  Name = "Ancient Apparition"},
            new HeroModel() { Id = 69,  NameEnum = Heroes.Doom,  Name = "Doom"},
            new HeroModel() { Id = 70,  NameEnum = Heroes.Ursa,  Name = "Ursa"},
            new HeroModel() { Id = 71,  NameEnum = Heroes.Spirit_Breaker,  Name = "Spirit Breaker"},
            new HeroModel() { Id = 72,  NameEnum = Heroes.Gyrocopter,  Name = "Gyrocopter"},
            new HeroModel() { Id = 73,  NameEnum = Heroes.Alchemist,  Name = "Alchemist"},
            new HeroModel() { Id = 74,  NameEnum = Heroes.Invoker,  Name = "Invoker"},
            new HeroModel() { Id = 75,  NameEnum = Heroes.Silencer,  Name = "Silencer"},
            new HeroModel() { Id = 76,  NameEnum = Heroes.Outworld_Devourer,  Name = "Outworld Devourer"},
            new HeroModel() { Id = 77,  NameEnum = Heroes.Lycan,  Name = "Lycan"},
            new HeroModel() { Id = 78,  NameEnum = Heroes.Brewmaster,  Name = "Brewmaster"},
            new HeroModel() { Id = 79,  NameEnum = Heroes.Shadow_Demon,  Name = "Shadow Demon"},
            new HeroModel() { Id = 80,  NameEnum = Heroes.Lone_Druid,  Name = "Lone Druid"},
            new HeroModel() { Id = 81,  NameEnum = Heroes.Chaos_Knight,  Name = "Chaos Knight"},
            new HeroModel() { Id = 82,  NameEnum = Heroes.Meepo,  Name = "Meepo"},
            new HeroModel() { Id = 83,  NameEnum = Heroes.Treant_Protector,  Name = "Treant Protector"},
            new HeroModel() { Id = 84,  NameEnum = Heroes.Ogre_Magi,  Name = "Ogre Magi"},
            new HeroModel() { Id = 85,  NameEnum = Heroes.Undying,  Name = "Undying"},
            new HeroModel() { Id = 86,  NameEnum = Heroes.Rubick,  Name = "Rubick"},
            new HeroModel() { Id = 87,  NameEnum = Heroes.Disruptor,  Name = "Disruptor"},
            new HeroModel() { Id = 88,  NameEnum = Heroes.Nyx_Assassin,  Name = "Nyx Assassin"},
            new HeroModel() { Id = 89,  NameEnum = Heroes.Naga_Siren,  Name = "Naga Siren"},
            new HeroModel() { Id = 90,  NameEnum = Heroes.Keeper_of_the_Light,  Name = "Keeper of the Light"},
            new HeroModel() { Id = 91,  NameEnum = Heroes.Io,  Name = "Io"},
            new HeroModel() { Id = 92,  NameEnum = Heroes.Visage,  Name = "Visage"},
            new HeroModel() { Id = 93,  NameEnum = Heroes.Slark,  Name = "Slark"},
            new HeroModel() { Id = 94,  NameEnum = Heroes.Medusa,  Name = "Medusa"},
            new HeroModel() { Id = 95,  NameEnum = Heroes.Troll_Warlord,  Name = "Troll Warlord"},
            new HeroModel() { Id = 96,  NameEnum = Heroes.Centaur_Warrunner,  Name = "Centaur Warrunner"},
            new HeroModel() { Id = 97,  NameEnum = Heroes.Magnus,  Name = "Magnus"},
            new HeroModel() { Id = 98,  NameEnum = Heroes.Timbersaw,  Name = "Timbersaw"},
            new HeroModel() { Id = 99,  NameEnum = Heroes.Bristleback,  Name = "Bristleback"},
            new HeroModel() { Id = 100, NameEnum = Heroes.Tusk,  Name = "Tusk"},
            new HeroModel() { Id = 101, NameEnum = Heroes.Skywrath_Mage,  Name = "Skywrath Mage"},
            new HeroModel() { Id = 102, NameEnum = Heroes.Abaddon,  Name = "Abaddon"},
            new HeroModel() { Id = 103, NameEnum = Heroes.Elder_Titan,  Name = "Elder Titan"},
            new HeroModel() { Id = 104, NameEnum = Heroes.Legion_Commander,  Name = "Legion Commander"},
            new HeroModel() { Id = 105, NameEnum = Heroes.Techies,  Name = "Techies"},
            new HeroModel() { Id = 106, NameEnum = Heroes.Ember_Spirit,  Name = "Ember Spirit"},
            new HeroModel() { Id = 107, NameEnum = Heroes.Earth_Spirit,  Name = "Earth Spirit"},
            new HeroModel() { Id = 108, NameEnum = Heroes.Underlord,  Name = "Underlord"},
            new HeroModel() { Id = 109, NameEnum = Heroes.Terrorblade,  Name = "Terrorblade"},
            new HeroModel() { Id = 110, NameEnum = Heroes.Phoenix,  Name = "Phoenix"},
            new HeroModel() { Id = 111, NameEnum = Heroes.Oracle,  Name = "Oracle"},
            new HeroModel() { Id = 112, NameEnum = Heroes.Winter_Wyvern,  Name = "Winter Wyvern"},
            new HeroModel() { Id = 113, NameEnum = Heroes.Arc_Warden,  Name = "Arc Warden"},
            new HeroModel() { Id = 114, NameEnum = Heroes.Monkey_King,  Name = "Monkey King"},
            new HeroModel() { Id = 119, NameEnum = Heroes.Dark_Willow,  Name = "Dark Willow"},
            new HeroModel() { Id = 120, NameEnum = Heroes.Pangolier,  Name = "Pangolier"},
            new HeroModel() { Id = 121, NameEnum = Heroes.Grimstroke,  Name = "Grimstroke"},
            new HeroModel() { Id = 123, NameEnum = Heroes.Hoodwink,  Name = "Hoodwink"},
            new HeroModel() { Id = 126, NameEnum = Heroes.Void_Spirit,  Name = "Void Spirit"},
            new HeroModel() { Id = 128, NameEnum = Heroes.Snapfire,  Name = "Snapfire"},
            new HeroModel() { Id = 129, NameEnum = Heroes.Mars,  Name = "Mars"},
        };

        public static List<HeroModel> GetHeroesMap() => _heroes;

        public static HeroModel GetHero(int id) =>
            _heroes.FirstOrDefault(h => h.Id == id);

        public static string GetHeroName(int id) => 
            GetHero(id)?.Name ?? "Unknown";

        public static HeroModel GetHero(Heroes nameEnum) =>
            _heroes.FirstOrDefault(h => h.NameEnum == nameEnum);

        public static string GetHeroName(Heroes nameEnum) =>
            GetHero(nameEnum)?.Name ?? "Unknown";

        public static int GetHeroId(Heroes nameEnum) =>
            GetHero(nameEnum)?.Id ?? 0;

        public static HeroModel FindHeroByName(string name) =>
            _heroes.FirstOrDefault(h => h.Name == name);
    }
}
