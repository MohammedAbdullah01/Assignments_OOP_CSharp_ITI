using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_1
{
    internal class Point3D
    {
        double x;
        double y;
        double z;


        public Point3D(double _x , double _y , double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void displayAll()
        {
            Console.WriteLine($"Coordinates = Point X = {x} \t Point Y = {y} \t Point Z = {z}");
        }

        public double CalculateDistance(Point3D p1 , Point3D p2)
        {
            double Distance_X = (p1.x - p2.x );
            if(Distance_X < 0 )
            {
                Distance_X = -Distance_X;

            }
            return Distance_X;
        }
    }
}
