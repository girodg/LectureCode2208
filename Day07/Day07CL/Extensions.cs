using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static List<BowWeapon> Bows(this Inventory inventory)
        {
            List<BowWeapon> bows = new List<BowWeapon>();
            foreach (FantasyWeapon item in inventory.Items)
            {
                if (item is BowWeapon bow)
                    bows.Add(bow);
            }
            return bows;
        }
        public static int CastSpell(this FantasyWeapon weapon, Spell spell)
        {
            Random rando = new Random();
            int damage;
            switch (spell)
            {
                case Spell.Fire:
                    damage = rando.Next(40);
                    break;
                case Spell.Lightning:
                    damage = rando.Next(50);
                    break;
                case Spell.Freeze:
                    damage = rando.Next(20);
                    break;
                case Spell.Shrink:
                    damage = rando.Next(5);
                    break;
                default:
                    damage = 0;
                    break;
            }
            damage += weapon.DoDamage();
            return damage;
        }


        public static ConsoleColor GetColor(this WeaponRarity rarity)
        {
            ConsoleColor color = ConsoleColor.Gray;
            switch (rarity)
            {
                case WeaponRarity.Common:
                    color = ConsoleColor.DarkGray;
                    break;
                case WeaponRarity.Uncommon:
                    color = ConsoleColor.Yellow;
                    break;
                case WeaponRarity.Rare:
                    color = ConsoleColor.Green;
                    break;
                case WeaponRarity.Legendary:
                    color = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            return color;
        }
    }
}
