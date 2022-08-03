using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[3] - one of the "cons" of arrays
            int[] nums = new int[3] {1,5,7};//contiguous in memory
            List<int> numList = nums.ToList();
            List<int> numList2 = new List<int>(nums);

            Console.WriteLine(nums[1]);//ex: mem address 0x1000
            //<memory address> + index * size of type
            //0x1000 + 1 * 4
            //one of the PROS of arrays
            //super fast lookup
            //PERFORMANCE:  order-of(1) or O(1) constant

            //what happens if I now need 5 ints?
            //CON:
            //resize "manually". not cheap.
            //to resize..
            int[] temp = new int[5];//allocating memory is "expensive"
            for (int i = 0; i < nums.Length; i++)
                temp[i] = nums[i];
            nums = temp;

            ArrayChallenge();

            List<string> backpack;//null
            backpack = new List<string>();// { "sword", "uzi", "hammer", "shoe" };
            Info(backpack);
            backpack.Add("brick");
            Info(backpack);//Count: 1  Capacity: 4
            backpack.Add("pipe bomb");
            Info(backpack);//Count: 2  Capacity: 4
            backpack.Add("sword");//Count: 3  Capacity: 4
            backpack.Add("uzi");//Count: 4  Capacity: 4
            backpack.Add("hammer");//Count: 5  Capacity: 8
            Info(backpack);
            backpack.Add("shoe");
            backpack.Add("chainsaw");
            backpack.Add("cast iron skillet");
            backpack.Add("beans");//Count: 9  Capacity: ?
            Info(backpack);
            Show(backpack);
            //Console.WriteLine(backpack[2]);//index of range exception

            ListChallenge();
        }

        private static void Show(List<string> backpack)
        {
            Console.WriteLine("---------INVENTORY--------");
            for (int i = 0; i < backpack.Count; i++)
            {
                Console.WriteLine(backpack[i]);
            }
        }

        static void Info(List<string> items)
        {
            //Count: # of items that have been ADDED
            //Capacity: Length of the internal array
            Console.WriteLine($"Count: {items.Count}\tCapacity: {items.Capacity}");
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random rando = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble()*100);
            }
            PrintGrades(grades);
            int numDropped = DropFailing(grades);
            PrintGrades(grades);
            Console.WriteLine($"{numDropped} grades were removed.");
            Console.ReadKey();

            List<double> curvedGrades = CurveGrades(grades);
            PrintGrades(curvedGrades);
        }

        static List<double> CurveGrades(List<double> course)
        {
            List<double> curved = new List<double>(course);
            for (int i = 0; i < curved.Count; i++)
            {
                //if (curved[i] > 95) curved[i] = 100;
                //else curved[i] += 5;

                //ternary operator
                //  shortened if-else
                curved[i] = (curved[i] > 95) ? 100 : curved[i] + 5;
            }
            return curved;
        }

        private static int DropFailing(List<double> grades)
        {
            int numDropped = 0;
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    if (grades[i] < 59.5)
            //    {
            //        numDropped++;
            //        grades.RemoveAt(i);
            //        i--;
            //    }
            //}
            //OR...use a reverse for loop
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    numDropped++;
                    grades.RemoveAt(i);
                }
            }
            return numDropped;
        }

        static void PrintGrades(List<double> course)
        {
            Console.Clear();
            Console.WriteLine("-----GRADES-----");
            foreach (var grade in course)
            {
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if(grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green; 

                // ,8 -- right-align in 8 spaces
                // :N2 -- format as a number with 2 decimal places
                Console.WriteLine($"{grade,8:N2}");
                Console.ResetColor();
            }
            Console.ReadKey();
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random randy = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randy.Next();
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
