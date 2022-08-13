using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat02
{
    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            do
            {
                Console.Write(prompt);
                if(int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;

                Console.WriteLine("That is not a valid number.");
            } while (true);
        }

        public static void ReadString(string prompt, ref string value)
        {
            do
            {
                Console.Write(prompt);
                value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value))
                    break;

                Console.WriteLine("That is not a valid string.");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] menuOptions, out int menuSelection)
        {
            foreach(string option in menuOptions)
                Console.WriteLine(option);

            menuSelection = ReadInteger(prompt, 1, menuOptions.Length);
        }
    }
}
