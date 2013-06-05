using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SurfaceShape
{
  public abstract class Shape
       {
          private double width;
          private double height;

          protected Shape(double width, double height)
      {
          this.Width = width;
          this.Height = height;
      }

      public double Width
      {
          get { return this.width; }
          set
          {
              if (value <= 0)
              {
                  throw new ArgumentOutOfRangeException("Width must to be bigger than 0");
              }
              this.width = value;
          }
      }

      public double Height 
      {
           get { return this.height; }

          set
          {
              if (value <= 0)
              {
                  throw new ArgumentOutOfRangeException("Width must to be bigger than 0");
              }
              this.height = value;
          }
      }

      protected Shape(double width)
      {
          this.Width = width;
      }

      public abstract double CalcSurface();
    }
}
