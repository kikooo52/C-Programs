using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SurfaceShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] newShape = 
            {
            new Triangle(5, 4),
          
            new Rectangle(3, 23),
           
            new Circle(222)        
        };
            foreach (var item in newShape)
            {
                Console.WriteLine("The surface of the {0}, is: {1}", item.GetType().Name, item.CalcSurface());
            }
        }
    }
}
