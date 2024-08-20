using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_7
{
    internal class Point3D
    {
        public int x , y, z;
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int _x) : this(_x,0, 0) { }
        public Point3D(int _x, int _y) : this (_x , _y , 0){}
        public Point3D(int _x , int _y , int _z)
        {
            x = _x;
            y = _y;
            z = _z;
            
        }

        public override bool Equals(object? obj)
        {
            if(obj is Point3D other)
            {
                return this.x == other.x && this.y == other.y && this.z == other.z;
            }
            return false;
        }

        public static bool operator== (Point3D point1 , Point3D point2)
        {
            if(ReferenceEquals(point1 , point2))
                return true;

            if (point1 is null || point2 is null)
                return false;

            return point1.Equals(point2);
        }


        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return point1.x != point2.x || point1.y != point2.y || point1.z != point2.z;
        }


        public override int GetHashCode()
        {
            return (x, y, z).GetHashCode();
        }


        public void Display()
        {
            Console.WriteLine($"Coordinates = Point X = {x} \t Point Y = {y} \t Point Z = {z}");
        }


        public void  ChangeCoordinates(int newX, int newY, int newZ)
        {

            x = newX; y = newY; z = newZ;
        }


        public void ChangeString(ref string myString)
        {
            myString = "New Value";
        }
    }
}
