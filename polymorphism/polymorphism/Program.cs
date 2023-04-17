using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
     class Program
    {
        static void Main(string[] args)
        {
            Shape obj1=new Shape();
            obj1.Drawshape();
            Circle obj2=new Circle();
            obj2.Drawshape();
            Rectangle obj3=new Rectangle();     
            obj3.Drawshape();
            
            Shape s1=new Circle();     //upcasting
            s1.Drawshape();

            Shape s2=new Rectangle();
            s2.Drawshape();

            //array of references of base class referencing derived class object(upcasting)

            Shape[] p =
            {
                new Circle(),
                new Rectangle(),
            };
            for (int i=0;i<p.Length;i++)
            
                p[i].Drawshape();
                Shape t = null;
                Console.WriteLine("enter the shape");
                string shape=Console.ReadLine();
                if (shape.ToLower() == "circle") 
                {
                    t = new Circle();
                }
               else if(shape.ToLower()== "rectangle")
                {
                    t= new Rectangle();

                }
                t.Drawshape();

            
        }
    }
    
}

