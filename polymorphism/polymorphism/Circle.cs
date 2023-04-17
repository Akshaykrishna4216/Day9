using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
     class Circle:Shape
    {
        public  override void Drawshape()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
