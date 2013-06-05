using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    public int PointX { get; set; }
    public int PointY { get; set; }
    public int PointZ { get; set; }

    private static readonly Point3D pointZero = new Point3D(0, 0, 0);

    public Point3D(int pointX, int pointY, int pointZ)  :this()
    {
        if (PointX < 5)
        {
          this.PointX = pointX;
        }
        this.PointY = pointY;
        this.PointZ = pointZ;
    }

    public Point3D PointZero
    {
        get
        {
            return pointZero;
        }
    }


    public override string ToString()
    {

         return "PointX:" + PointX + ", PointY:" + PointY + ", PointZ:" + PointZ;
    }
}
