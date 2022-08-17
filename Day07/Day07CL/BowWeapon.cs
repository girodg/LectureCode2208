using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public int ArrowCount { get; set; }
        public int ArrowCapacity { get; set; }

        public BowWeapon(int count, int capacity, WeaponRarity rarity, int level, int maxDamage, int cost) 
            : base(rarity, level, maxDamage, cost)    
        {
            ArrowCapacity = capacity;
            ArrowCount = count;
        }
    }
}
