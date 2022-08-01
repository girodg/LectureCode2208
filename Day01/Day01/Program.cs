﻿using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string location = Console.ReadLine();
            //Console.WriteLine($"Hello {location}!");

            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);
            Timestamp(ref msg);
            PrintMessage(msg);

            string numberStr = "Steev";
            bool wasGood = IntTryParse(numberStr, out int num);
            if (wasGood) Console.WriteLine(num);

            Player p1 = new Player();
            int spacesToMove = 3;
            p1.MoveRight(spacesToMove);
            int xp = 0, yp = 0;
            p1.GetPosition(ref xp, ref yp);
            Console.WriteLine($"You are at: {xp},{yp}");

            int x1 = 0, y1 = 0;
            p1.GetPosition(ref x1, ref y1);
            Console.WriteLine(DateTime.Now);
        }

        static bool IntTryParse(string toParse, out int number)
        {
            bool parsed = false;
            try
            {
                number = int.Parse(toParse);//required to assign a value to number
                parsed = true;
            }
            catch (Exception)
            {
                Console.WriteLine("That was NOT a number!");
                number = 0;
            }            
            return parsed;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetMessage()
        {
            Console.Write("Please enter your location: ");
            string message = Console.ReadLine();
            return message;
        }

        static void Timestamp(ref string messageToStamp)
        {
            //$ - interpolated string
            messageToStamp = $"{DateTime.Now}: {messageToStamp}";
        }
    }
    class Player
    {
        int x = 0, y = 0;

        public void MoveRight()
        {
            if (x < Console.WindowWidth - 1)
                x++;
        }

        public void MoveRight(int spaces)//pass by value
        {
            if (x + spaces <= Console.WindowWidth - 1)
                x += spaces;
        }

        public void GetPosition(ref int xpos, ref int ypos)//pass by reference
        {
            xpos = x;
            ypos = y;
        }
    }
}
