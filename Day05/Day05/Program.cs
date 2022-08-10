using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Day05
{
    internal class Program
    {
        static Dictionary<int, ulong> _fibs = new();
        static void Main(string[] args)
        {
            //Console.ReadKey();
            //int size = Math.Min(Console.WindowHeight, Console.WindowWidth);
            //Rect(size);
            //Console.ResetColor();
            //Console.ReadKey();

            _fibs.Add(0, 0);
            _fibs[1] = 1;

            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 145; i++)
            {
                sw.Restart();
                ulong fibResult = Fib2(i);
                sw.Stop();
                long ms = sw.ElapsedMilliseconds;
                Console.Write($"Fib({i}) = {fibResult}");
                Console.CursorLeft = 60;
                Console.WriteLine($"{ms} ms");
            }
            int[] nums = new int[] { 5, 13, 7, 8, 42 };
            Swap(nums, 1, 2);
            for (int i = 0; i < nums.Length; i++)
                Console.Write($"{nums[i]} ");
            Console.WriteLine();
            Console.ReadKey();

            string s1 = "Batman", s2 = "Aquaman";
            int comp = s1.CompareTo(s2);
            // -1:  LESS THAN
            //  0:  EQUAL TO
            //  1:  GREATER THAN
            if (comp == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if (comp > 0) Console.WriteLine($"{s1} GREATER THAN {s2}");
            else if (comp < 0) Console.WriteLine($"{s1} LESS THAN {s2}");

            Split(nums.ToList());

            Console.ReadKey();

            Bar(0);

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

        private static void Rect(int size)
        {
            if(size <= 0) return;

            Console.BackgroundColor = RandomColor();
            Horizontal(Console.CursorLeft, Console.CursorTop, size);
            Horizontal(Console.CursorLeft, Console.CursorTop+size, size);
            Vertical(Console.CursorTop, Console.CursorTop, size);
            Vertical(Console.CursorLeft+size, Console.CursorTop, size);
            Console.CursorLeft++;
            Console.CursorTop++;
            Rect(size - 2);
        }

        private static void Vertical(int cursorLeft, int cursorTop, int size)
        {
            int x0 = Console.CursorLeft;
            int y0 = Console.CursorTop;
            for (int i = cursorTop; i <= cursorTop+size; i++)
            {
                Console.SetCursorPosition(cursorLeft, i);
                Console.Write(' ');
            }
            Console.SetCursorPosition(x0, y0);
        }

        private static void Horizontal(int cursorLeft, int cursorTop, int size)
        {
            int x0 = Console.CursorLeft;
            int y0 = Console.CursorTop;
            Console.SetCursorPosition(cursorLeft, cursorTop);
            for (int i = cursorLeft; i <= cursorLeft+size; i++)
            {
                Console.Write(' ');
            }
            Console.SetCursorPosition(x0, y0);
        }

        static ulong Fib(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            return Fib(N - 1) + Fib(N - 2);
        }

        static ulong Fib2(int N)
        {
            if (_fibs.TryGetValue(N, out ulong result))
                return result;
            result = Fib2(N - 1) + Fib2(N - 2);
            _fibs[N] = result;
            return result;
        }

        static Random randy = new Random();

        private static void Bar(int x)
        {
            if (x < Console.WindowWidth)
            {
                Console.CursorLeft = x;
                Console.BackgroundColor = RandomColor();
                Console.Write(' ');
                Thread.Sleep(100);

                Bar(x + 1);

                Console.CursorLeft = x;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                Thread.Sleep(100);
            }
        }

        static ConsoleColor RandomColor()
        {
            ConsoleColor current = Console.BackgroundColor;
            ConsoleColor newColor;
            while ((newColor = (ConsoleColor)randy.Next(16)) == current) ;
            return newColor;
        }

        private static void Split(List<int> original)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = original.Count / 2;
            for (int i = 0; i < original.Count; i++)
            {
                if (i < mid)
                    left.Add(original[i]);
                else
                    right.Add(original[i]);
            }
            Console.WriteLine("LEFT");
            foreach (var item in left)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("RIGHT");
            foreach (var item in right)
            {
                Console.WriteLine(item);
            }
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
            if (i < 100)//exit condition
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
