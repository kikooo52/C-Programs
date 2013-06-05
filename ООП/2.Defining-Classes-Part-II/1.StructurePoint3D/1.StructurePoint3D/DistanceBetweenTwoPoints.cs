using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
 public static class DistanceBetweenTwoPoints
    {
     public static double CalculateDistance(Point3D firstPoint, Point3D secontPoint)
     {
         double distance = 0;
         distance = Math.Sqrt(Math.Pow(firstPoint.PointX - secontPoint.PointX, 2) + Math.Pow(firstPoint.PointY - secontPoint.PointY, 2) + Math.Pow(firstPoint.PointZ - secontPoint.PointZ, 2 ));
         return distance;
     }     
    }
}
