using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        //ACCESS MODIFIERS:
        //private: ONLY this class can see it
        //public: EVERYONE can see it
        //protected: this class and all my descendent classes can see it

        #region Fields
        //FIELDS: data of your object
        //
        private ConsoleColor _color;
        private int _x, _y;

        private static int _numberOfGameObjects = 0;
        #endregion

        #region Properties

        //code-snippets:
        //prop: auto-prop
        //propfull: full property 

        //full property: you create the backing field (_color)
        public ConsoleColor Color
        {
            //get (accessor)
            //same as public ConsoleColor GetColor() {return _color;}
            get
            {
                return _color;
            }

            //set (mutator)
            //same as public void SetColor(ConsoleColor value) {_color = value;}
            set //hidden parameter: ConsoleColor value
            {
                if (value != ConsoleColor.DarkYellow)
                    _color = value;
            }
        }

        //an auto-prop: the compiler provides the backing field
        public char Symbol { get; private set; }

        #endregion

        #region Constructors

        //a default constructor is provided by the compiler IFF you do not provide any constructor
        //public GameObject() { }

        //SPECIAL methods that initialize your object
        public GameObject(ConsoleColor color, char symbol, int x, int y)
        {
            Console.WriteLine($"GameObject: {symbol}");
            Color = color;
            Symbol = symbol;
            _numberOfGameObjects++;
            _x = x;
            _y = y;
        }


        #endregion

        #region Methods

        //instance methods have a hidden parameter: this
        //this is the instance that the method was called on
        public void DrawMe()//GameObject this
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(_x, _y);
            Console.Write(Symbol);
            Console.ResetColor();
        }

        //STATIC methods do NOT have 'this' parameter
        public static void Info()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine($"Game Objects: {_numberOfGameObjects}");
        }

        #endregion

    }
}
