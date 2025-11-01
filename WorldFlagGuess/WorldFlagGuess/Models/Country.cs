using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFlagGuess.Models
{
    public enum ContinentType
    {
        Asia,           // chau A
        Europe,         // chau Au
        NorthAmerica,   // chau Bac My        
        SouthAmerica,   // chau Nam My
        Oceania,        // chau Dai Duong
        Africa,         // chau Phi
        Antarctica,     // chau Nam Cuc
    }

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
        public long Population { get; set; }
        public int Area { get; set; } // km2
    }
}
