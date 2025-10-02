using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCard2
{
    public class Attack
    {
        public string Name { get; set; }

        public PokemonType Type { get; set; }
        public string ADescription { get; set; }
        public int Damage { get; set; }

        public Attack(string name, string aDescription, int damage)
        {
            Name = name;
            ADescription = aDescription;
            Damage = damage;
            

        }
    }
}
