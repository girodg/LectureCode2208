using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 13, 2, 7, 42 };
            int search = 42;
            int indexOf = LinearSearch(numbers, search);
            Console.WriteLine($"{search} was {((indexOf == -1)?"NOT " : "")}found.");
            if(indexOf >= 0)
                Console.WriteLine($"at index {indexOf}");
        }

        //Performance: O(N) - linear
        private static int LinearSearch(List<int> numbers, int searchNumber)
        {
            int index = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(searchNumber == numbers[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
