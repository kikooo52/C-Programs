using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
   public class Path
    {
        public List<Point3D> PointsList = new List<Point3D>();

        public Path()
        {
        }

        public List<Point3D> Paths
        {
            get { return this.PointsList; }
        }

        public void AddPoints(Point3D point)
        {
            PointsList.Add(point);
        }
        public void ClearPoint()
        {
            PointsList.Clear();
        }
        public void PrintPoint()
        {
            foreach (var item in PointsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
