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
