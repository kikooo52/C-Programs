using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(4, 5, 6);
            firstPoint.PointX = 4;
            Point3D seconPoint = new Point3D(1, 1, 0);
            Point3D thirdPoint = new Point3D(3, 3, 1);

            Console.WriteLine(firstPoint.ToString());

            Console.WriteLine(firstPoint.PointZero);

            Console.WriteLine(DistanceBetweenTwoPoints.CalculateDistance(firstPoint, seconPoint));

            Path pathOne = new Path();
            pathOne.AddPoints(firstPoint);
            pathOne.AddPoints(seconPoint);
            pathOne.AddPoints(thirdPoint);


            PathStorage.SavePathInFile(pathOne);
            PathStorage.LoadPath();

          

            
        }
    }
}
         