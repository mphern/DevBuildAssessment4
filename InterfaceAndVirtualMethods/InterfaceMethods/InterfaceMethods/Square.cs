using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    class Square : Shape
    {
        private double side;

        public Square() : base()
        {
            side = 0;
        }

        public Square(double Side) : base()
        {
            side = Side;
        }

        public double Side { get { return side; } set { side = value; } }

        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square!");
        }

        public double GetArea()
        {
            return side * side;
        }

        /*This class utilizes the Liskov Substitution Principal through overiding a 
         * parent funtion without breaking the application.  Through inheritance you are
         * also implementing the Open/Closed Principle in allowing for new functionality
         * (like adding new shapes) without changing existing code. */

    }
}
