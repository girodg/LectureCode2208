using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

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
                        Superhero meh = new Superhero() { Name = "Aquaman", SecretIdentity = "Steev", Power = Powers.Swimming };

            string filePath = @"C:\temp\2208\Heroes.txt";

            string extension = Path.GetExtension(filePath);
            bool hasExtension = Path.HasExtension(filePath);
            string newFilePath = Path.ChangeExtension(filePath, "gif");
            #region CSV
            Superhero best = new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Power = Powers.Money };
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
            #endregion

            #region JSON

            #region Serializing (saving)

            string jsonFilePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(jsonFilePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, bats);
                }
            }
            #endregion

            #region Deserialize (loading)
            if(File.Exists(jsonFilePath))
            {
                string superText = File.ReadAllText(jsonFilePath);

                Console.WriteLine("-------DESERIALIZING---------");
                try
                {
                    Superhero superhero = JsonConvert.DeserializeObject<Superhero>(superText);
                    Console.WriteLine($"{superhero.Name} ({superhero.SecretIdentity}) {superhero.Power}");
                }
                catch (Exception)
                {
                }
            }
            else
                Console.WriteLine($"ERROR: {jsonFilePath} does not exists!!");
            #endregion
            #endregion

        }

        static void ReadFile(string filePath)
        {
            using StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            Console.WriteLine(line);
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
