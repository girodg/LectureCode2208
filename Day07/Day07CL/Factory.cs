using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        //everything in a static class MUST be static
        
        public static GameObject BuildGameObject(ConsoleColor color, char symbol, int x, int y)
        {
            return new GameObject(color, symbol, x, y);
        }

        public static FantasyWeapon CreateWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            return new FantasyWeapon(rarity, level, maxDamage, cost);
        }
    }
}
