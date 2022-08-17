using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    // Derived : Base
    public class Player : GameObject
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }

        public Player(string name, int score, int health, ConsoleColor color, char symbol, int x, int y) 
            : base(color, symbol, x, y) //call the base constructor
        {
            Console.WriteLine($"Player: {name} ({Symbol})");
            Name = name;
            Score = score;
            Health = health;
        }
    }
}
