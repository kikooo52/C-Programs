using System;
using System.Linq;

namespace CorrectUseOfVariables
{
    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set;}

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigure)
        {
            double anglleSinus = Math.Abs(Math.Sign(angleOfTheFigure));
            double anglleCosinus = Math.Abs(Math.Cos(angleOfTheFigure));

            double width = (anglleCosinus * size.Width) + (anglleSinus * size.Height);
            double height = (anglleSinus = size.Width) + (anglleCosinus * size.Width);

            Size rotatedSize = new Size(width, height);

            return rotatedSize;
        }

        static void Main(string[] args)
        {
            Size aaa = new Size(55, 44);
            Console.WriteLine(GetRotatedSize(aaa, 123));
        }
    }
}
 