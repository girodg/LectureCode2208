using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 13, 7, 8, 42 };
            Swap(nums, 1, 2);
            for (int i = 0; i < nums.Length; i++)
                Console.Write($"{nums[i]} ");
            Console.WriteLine();
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            int num = Counter(0);
            Console.WriteLine(num);
            Console.ResetColor();

            long result = Factorial(5);
            Console.WriteLine($"5! = {result}");
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            //int temp = nums[index1];
            //nums[index1] = nums[index2];
            //nums[index2] = temp;

            (nums[index2], nums[index1]) = (nums[index1], nums[index2]);
        }

        static long Factorial(int N)
        {
            if (N > 1)
            {
                long result = N * Factorial(N - 1);
                return result;
            }
            return 1;
        }


        static int Counter(int i)
        {
            int result = 100;
            if(i < 100)//exit condition
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(i);

                result = Counter(i + 1);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
            return result;
        }
    }
}
