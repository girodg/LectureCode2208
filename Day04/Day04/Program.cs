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

            Superhero bats = new Superhero();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiter);
                    bats.Name = parts[0];
                    bats.SecretIdentity = parts[1];
                    bats.Power = Enum.Parse<Powers>(parts[2]);
                }
            }
            //OR...read the entire file then process it
            string fileText = File.ReadAllText(filePath);//open, read, close the file

            Console.WriteLine($"{bats.Name} ({bats.SecretIdentity}) {bats.Power}");

            string challengePath = "scores.txt";
            WriteData(challengePath);
            ReadData(challengePath);
        }

        #region CSV
        static void WriteData(string fPath)
        {
            List<int> ints = new List<int>() { 5, 4, 3, 2, 1 };

            char delimiter = '?';
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                bool isNotFirst = false;
                for (int i = 0; i < ints.Count; i++)
                {
                    if(isNotFirst)
                        sw.Write(delimiter);
                    sw.Write(ints[i]);
                    isNotFirst = true;
                }
            }

        }
        private static void ReadData(string challengePath)
        {
            List<int> nums = new List<int>();
            char delimiter = '?';
            using (StreamReader sr = new StreamReader(challengePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(delimiter);
                    foreach (var part in parts)
                    {
                        if(int.TryParse(part, out int num))
                            nums.Add(num);
                    }
                }
                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
            }
        }
        #endregion
    }
}
