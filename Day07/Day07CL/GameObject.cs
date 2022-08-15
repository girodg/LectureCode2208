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

        //FIELDS: data of your object
        //
        private ConsoleColor _color;
        private int _x, _y;

        //full property: you create the backing field (_color)
        public ConsoleColor Color
        {
            //get (accessor)
            //same as public ConsoleColor GetColor() {return _color;}
            get { 
                return _color; 
            }

            //set (mutator)
            //same as public void SetColor(ConsoleColor value) {_color = value;}
            set //hidden parameter: ConsoleColor value
            {
                if(value != ConsoleColor.DarkYellow)
                    _color = value;
            }
        }

        //an auto-prop: the compiler provides the backing field
        public char Symbol { get; private set; }

        void DrawMe()
        {
        }

    }
}
