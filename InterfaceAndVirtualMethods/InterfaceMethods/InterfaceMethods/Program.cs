using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Square square1 = new Square();
            Square square2 = new Square(6);


            shape.Draw();
            square1.Draw();
            Console.WriteLine(square1.Side);
            square2.Draw();
            Console.WriteLine(square2.Side);
            Console.WriteLine(square2.GetArea());
        }
    }
}
