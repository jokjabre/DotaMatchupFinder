using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Mappings
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HeroEnum NameEnum { get; set; }
    }
}
