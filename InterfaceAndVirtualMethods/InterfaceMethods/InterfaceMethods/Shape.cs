using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    class Shape
    {

        public Shape()
        {
        }

        public virtual void Draw()
        {
            Console.WriteLine("Hi, I am a shape!");
        }
    }
}
