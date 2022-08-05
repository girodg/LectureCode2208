using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    enum ZombieClass
    {
        Regular, Exploding, Crawler, Baby, Spitters
    }
    class Zombie
    {
        public ZombieClass ZombieType { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12, 54, 96, 86 };
            List<string> students = new List<string>() { "Steev", "Bob", "Bruce", "Dick" };
            Console.WriteLine(grades[1]);//use the index

            //performance of indexing into an array/list? O(1) - constant
            //Finding an item? O(N) where N is the # of items. Linear.

            //3 ways:
            //  1 & 2 require that the key NOT be in the dictionary
            //  1. initializer
            //  2. Add method

            //  3 simply overwrites the value if the key is already in the dictionary
            //  3. [ ]


            Dictionary<ZombieClass, Zombie> monsters = new()
            {
                //{ key, value }
                { ZombieClass.Regular, new Zombie() { Speed = 5, Damage = 10, Health = 50, Level = 1, MaxHealth = 50, ZombieType = ZombieClass.Regular } }
            };
            monsters.Add(ZombieClass.Spitters, new Zombie() { });
            try
            {
                monsters.Add(ZombieClass.Spitters, new Zombie() { });//will throw an exception!

            }
            catch (Exception)
            {
                Console.WriteLine("Zombie.Spitters are already in the dictionary.");
            }
            monsters[ZombieClass.Exploding] = new Zombie();
            monsters[ZombieClass.Exploding] = new Zombie();//will overwrite the value. NO exception.
            foreach (KeyValuePair<ZombieClass, Zombie> kvp in monsters)
            {
                //Key and Value properties on kvp
                Console.WriteLine($"{kvp.Key}\tSpeed: {kvp.Value.Speed}");
            }

            DictionaryChallenge();

        }

        private static void DictionaryChallenge()
        {
            List<string> students = new() { "Quinton", "Forrest", "Bailey", "Rayshawn", "Hunter", "Zachary", "Bobby", "Justin", "Orlando", "Jacob", "Brandi", "Garrett" };
            Dictionary<string, double> pg2 = new();
            Random rando = new Random();
            foreach (var student in students)
            {
                pg2.Add(student, rando.NextDouble() * 100);
                //OR
                pg2[student] = rando.NextDouble() * 100;
            }


        }
    }
}
