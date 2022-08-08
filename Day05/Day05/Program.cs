using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
