using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Day04
{
    enum Powers
    {
        Speed, Flying, ShapeShifting, Money, Swimming, Strength
    }

    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Powers Power { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Superhero best = new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Power = Powers.Money };

            string filePath = @"C:\temp\2208\Heroes.txt";
            char delimiter = '>';
            //1. open the file.
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2. write to the file
                sw.Write(best.Name);
                sw.Write(delimiter);
                sw.Write(best.SecretIdentity);
                sw.Write(delimiter);
                sw.Write(best.Power);
            }//3. CLOSE THE FILE!!
        }
    }
}
