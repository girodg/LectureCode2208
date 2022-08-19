using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        public int DoDamage()
        {
            Random rando = new Random();
            return (int)(rando.NextDouble() * MaxDamage);
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nI have a level {Level} {Rarity} weapon that can do {MaxDamage} of damage. It costs {Cost}");

        }
    }
}
