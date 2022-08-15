using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject gObj = new GameObject(ConsoleColor.Blue, '?');
            gObj.Color = ConsoleColor.DarkCyan;//call the set on Color
            ConsoleColor theColor = gObj.Color;//call the get on Color
            Console.WriteLine(gObj.Color);//?? set or get? get

            //gObj.Symbol = '?';
        }
    }
}
