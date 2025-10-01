using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCard2
{
    public class Pokemon
    {
        public string Name { get; set; }

        public int Number { get; set; }
        public int MaxDeckNumber { get; set; }

        public string Category {get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        
        public string Type { get; set; }
        public int HP { get; set; }
        public string ImagePath { get; set; }
        public List<Attack> Attacks { get; set; }  = new List<Attack>();

        public string Description { get; set; }

        public string Weakness { get; set; }

        public Pokemon(string name, string category,  int number, double height, double weight, string type, int hp, string imagePath, string description, string weakness, List<Attack> attacks)
        {
            Name = name;
            Category = category;
            Height = height;
            Weight = weight;
            Number = number;
            Type = type;
            HP = hp;
            ImagePath = imagePath;
            Description = description;
            Weakness = weakness;
            Attacks = attacks ?? new List<Attack>();

        }

        public virtual string SubInfo() => $" NO.{Number} {Category} Pokemon HT: {Height}'' WT: {Weight} lbs.";    

        

        
    }
}
