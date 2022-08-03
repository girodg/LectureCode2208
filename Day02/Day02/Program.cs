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
            //Console.WriteLine(backpack[2]);//index of range exception
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
