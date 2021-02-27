using DotaMatchupFinder.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Heroes NameEnum { get; set; }
    }
}
