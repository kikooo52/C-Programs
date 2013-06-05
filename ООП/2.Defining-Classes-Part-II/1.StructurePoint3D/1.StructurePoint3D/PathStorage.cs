using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StructurePoint3D
{
    public static class PathStorage
    {
        public static void SavePathInFile(Path point)
        {
            using (StreamWriter writer = new StreamWriter(@"../../PathssWrite.txt"))
            {
                foreach (var item in point.Paths)
                {
                    writer.WriteLine(item);
                }
            }
        }
        public static void LoadPath()
        {
            Path loadPath = new Path();
            List<Path> loadedPath = new List<Path>();
            using (StreamReader reader = new StreamReader(@"../../PathssLoad.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {

                    Point3D pointsFromFile = new Point3D();
                    string[] points = line.Split(',');

                    int insex = points[0].IndexOf(":", 1);
                    string removeText = points[0].Remove(0, insex + 1);
                    pointsFromFile.PointX = int.Parse(removeText);

                    insex = points[1].IndexOf(":", 1);
                    removeText = points[1].Remove(0, insex + 1);
                    pointsFromFile.PointY = int.Parse(removeText);

                    insex = points[2].IndexOf(":", 1);
                    removeText = points[2].Remove(0, insex + 1);
                    pointsFromFile.PointZ = int.Parse(removeText);
                    loadPath.AddPoints(pointsFromFile);


                    loadedPath.Add(loadPath);
                    loadPath = new Path();
                    line = reader.ReadLine();
                }
            }
            foreach (var item in loadedPath)
            {
                item.PrintPoint();
            }
        }


    }
}

