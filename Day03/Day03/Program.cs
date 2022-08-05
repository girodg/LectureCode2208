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
            monsters.Add(ZombieClass.Spitters, new Zombie() { });//will throw an exception!

            monsters[ZombieClass.Exploding] = new Zombie();
            monsters[ZombieClass.Exploding] = new Zombie();//will overwrite the value. NO exception.
        }
    }
}
