using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_6
{
    internal class Point3D
    {
        int x, y, z;

        public Point3D() : this(0,0, 0)
        {

        }
        public Point3D(int _x) : this(_x,0, 0)
        {

        }
        public Point3D(int _x , int _y) : this( _x,  _y , 0)
        {
            
        }
        public Point3D(int _x , int _y , int _z)
        {
            x = _x;
            y = _y;
            z = _z;
            
        }


        public override string ToString()
        {
            return $"X = {x} \t Y = {y} \t Z = {z}";

        }


        public override bool Equals(object? obj)
        {
            //Point3D point = obj as Point3D;
            //if(point == null )
            //{
            //    return false;
            //}
            //    return this.x == point.x && this.y == point.y && this.z == point.z;

            //Solution another
            if (obj is Point3D)
            {
                Point3D point = (Point3D)obj;

                return this.x == point.x && this.y == point.y && this.z == point.z;
            }
            return false;
        }


        public static void Display(Point3D[] arr)
        {
            foreach (Point3D p in arr)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
