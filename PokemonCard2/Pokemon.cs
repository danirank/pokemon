using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCard2
{
    public enum PokemonType
    {
        Water,
        Fire,
        Grass,
        Electric,
        Psychic,
        Fighting,
        Dark,
        Fairy,
        Dragon,
        Colorless
    }
    public class Pokemon
    {
        public string Name { get; set; }

        
        public int SetNumber { get; set; }
        public int MaxDeckNumber { get; set; }

        public string Category {get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        
        public PokemonType Type { get; set; }

        public string TypeImg { get; set; }
        public int HP { get; set; }
        public string ImagePath { get; set; }
        public List<Attack> Attacks { get; set; }  = new();

        public string Description { get; set; }

        public PokemonType Weakness { get; set; }

        public string FooterText { get; set; } 

        public string Rarity { get; set; }

        public static readonly Dictionary<PokemonType, string> TypeImages = new()
    {
        { PokemonType.Water, "💧" },
        { PokemonType.Fire, "🔥" },
        { PokemonType.Grass, "🌿" },
        { PokemonType.Electric, "⚡" },
        { PokemonType.Psychic, "🧠" },
        { PokemonType.Fighting, "🥊" },
        { PokemonType.Dark, "🌑" },
        { PokemonType.Fairy, "✨" },
        { PokemonType.Dragon, "🐉" },
        { PokemonType.Colorless, "⬜" }
    };


        public Pokemon(
        string name, string category, int number,
        double height, double weight,
        PokemonType type, int hp,
        string imagePath, string description,
        PokemonType weakness, List<Attack> attacks)
        {
            Name = name;
            Category = category;
            SetNumber = number;
            Height = height;
            Weight = weight;
            Type = type;
            HP = hp;
            ImagePath = imagePath;
            Description = description;
            Weakness = weakness;
            Attacks = attacks ?? new();

            // slå upp emoji, med fallback
            if (!TypeImages.TryGetValue(type, out var icon))
                icon = "❓";
            TypeImg = icon;
        }

        public virtual string SubInfo() => $" NO.{SetNumber} {Category} Pokemon HT: {Height}'' WT: {Weight} lbs.";    

        

        
    }
}
