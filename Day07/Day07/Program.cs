using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject gObj = new GameObject(ConsoleColor.Blue, '?', 10, 5);
            gObj.Color = ConsoleColor.DarkCyan;//call the set on Color
            ConsoleColor theColor = gObj.Color;//call the get on Color
            Console.WriteLine(gObj.Color);//?? set or get? get

            gObj.DrawMe();
            try
            {
                GameObject.Info();
            }
            catch (Exception)
            {
            }

            List<string> items = new List<string>()
            {
                "map", "flashlight", "shovel"
            };
            Inventory backpack = new Inventory(3, items);
            try
            {
                backpack.AddItem("spear");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"I swing sting and do {damage} damage to the rat.");

            //gObj.Symbol = '?';
            Console.ReadKey();
        }
    }
}
