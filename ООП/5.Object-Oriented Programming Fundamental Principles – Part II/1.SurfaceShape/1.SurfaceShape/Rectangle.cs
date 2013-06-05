using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SurfaceShape
{
   public class Rectangle : Shape
    {
        public Rectangle(double wight, double height)
            : base(wight,height)
        { }

        public override double CalcSurface()
        {
            return this.Height * this.Width;
        }
    }
}
