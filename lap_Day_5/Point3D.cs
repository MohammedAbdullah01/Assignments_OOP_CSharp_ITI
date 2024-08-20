using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lap_Day_5
{
    internal class Point3D
    {
        int x;
        int y;
        int z;

        public Point3D(int _x , int  _y , int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public static bool operator==(Point3D point1 , Point3D point2)
        {
            return (point1.x == point2.x && point1.y == point2.y && point1.z == point2.z);
        }

        public static bool operator!=(Point3D point1, Point3D point2)
        {
            return (point1.x != point2.x || point1.y != point2.y || point1.z != point2.z);
        }


    }
}
