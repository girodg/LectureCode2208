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
            bool wasRemoved = monsters.Remove(ZombieClass.Baby);
            if(!wasRemoved)
                Console.WriteLine("Baby zombies not in the dictionary.");
            else
                Console.WriteLine("Baby zombies were removed.");


            //2 ways to check
            //1. ContainsKey
            //2. TryGetValue

            //1. ContainsKey
            if (monsters.ContainsKey(ZombieClass.Baby))
            {
                Zombie baby = monsters[ZombieClass.Baby];
                baby.Speed = 30;
            }

            //2. TryGetValue
            if(monsters.TryGetValue(ZombieClass.Baby, out Zombie babyZ))
            {
                monsters[ZombieClass.Baby] = new Zombie() { Speed = 40 };//overwrite the existing value
            }

            DictionaryChallenge();

        }
        #region Dictionary Methods

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

            PrintGrades(pg2);
            DropStudent(pg2);
            CurveStudent(pg2);
        }

        static void CurveStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Please enter the name of the student to curve: ");
                string student = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(student)) break;

                if (course.TryGetValue(student, out double grade))
                    course[student] = (grade > 95) ? 100 : grade + 5;
                else
                    Console.WriteLine($"{student} was not in the course.");

                PrintGrades(course);
            } while (true);
        }

        static void DropStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Please enter the name of the student to drop: ");
                string student = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(student)) break;

                bool wasRemoved = course.Remove(student);
                if (wasRemoved)
                    Console.WriteLine($"{student} was removed from the course.");
                else
                    Console.WriteLine($"{student} was not in the course.");
                PrintGrades(course);
            } while (true);
        }

        static void PrintGrades(Dictionary<string, double> course)
        {
            Console.WriteLine("---------GRADES-----------");
            foreach (var student in course)
            {
                double grade = student.Value;
                string name = student.Key;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;
                Console.Write($"{grade,8:N2}");
                Console.ResetColor();
                Console.WriteLine($" {name}");
            }
        } 
        #endregion
    }
}
