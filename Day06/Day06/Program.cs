using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        enum Superpowers
        {
            Money, Knowledge, Strength, Teleportation
        }

        static void Main(string[] args)
        {

            Superpowers myPowers = Superpowers.Teleportation;
            switch (myPowers)
            {
                case Superpowers.Money:
                    break;
                case Superpowers.Knowledge:
                    break;
                case Superpowers.Strength:
                    break;
                case Superpowers.Teleportation:
                    break;
                default:
                    break;
            }

            List<int> numbers = new List<int>() { 5, 13, 2, 7, 42 };
            int search = 4;
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
