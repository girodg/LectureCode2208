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

        void DrawMe()
        {
            ConsoleColor color;
            _color = ConsoleColor.Green;
        }

    }
}
