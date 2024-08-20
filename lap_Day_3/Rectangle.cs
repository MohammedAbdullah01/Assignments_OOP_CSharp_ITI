using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_3
{
    internal class Rectangle
    {
        protected Point2D p1;
        protected Point2D p2;

        public Rectangle(Point2D _p1, Point2D _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }

        public int CalculateArea()
        {
            int width = Math.Abs( p2.x - p1.x);
            int height = Math.Abs(p2.y - p1.y);
            return width * height;
        }
    }
}
