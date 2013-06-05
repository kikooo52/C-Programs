using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SurfaceShape
{
   public class Circle : Shape
    {
        public Circle(double Width) :base(Width)
        {
        }

        public override double CalcSurface()
        {
            return Math.PI * this.Width * this.Width;
        }
    }
}
