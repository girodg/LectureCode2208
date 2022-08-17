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

        public void MoveRight()
        {
            _x++;
            if (_x >= Console.WindowWidth)
                _x = 0;
        }

        public void MoveLeft()
        {
            _x--;
            if (_x <0) 
                _x = Console.WindowWidth-1;
        }

        public void MoveUp()
        {
            _y--;
            if (_y < 0)
                _y = Console.WindowHeight - 1;
        }

        public void MoveDown()
        {
            _y++;
            if (_y >= Console.WindowHeight)
                _y = 0;
        }

        public void Debug()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"Player: {_x},{_y}");

        }

    }
}
