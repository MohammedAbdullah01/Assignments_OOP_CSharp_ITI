using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_2
{
    internal class Point3d
    {
        int x;
        int y;
        int z;

        public Point3d() : this(0, 0, 0)
        {

        }
        public Point3d(int _x):this(_x , 0 ,0)
        {

        }
        public Point3d(int _x , int _y):this(_x , _y , 0)
        {

        }
        public Point3d(int _x , int _y , int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }


        public int CalculateDistance(Point3d p2)
        {
            int Distance = x - p2.x;
            if (Distance < 0)
            {
                Distance = -Distance;
            }
            return Distance;
        }

        public void Display()
        {
            Console.WriteLine($"Coordinates X = ({x})\t Y = ({y})\t Z = ({z})");
        }
    }
}
