using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SurfaceShape
{
    class Triangle : Shape
    {
        public Triangle(double wight, double height)
            : base(wight,height)
        { }

        public override double CalcSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
