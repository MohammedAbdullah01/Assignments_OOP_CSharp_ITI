using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_3
{
    internal class Line
    {
        Point2D[] Point2D = new Point2D[2];
        int index = 0;


        public void  AddPoint2D(Point2D p)
        {
            Point2D[index++] = p;
        }

        public int GetLength()
        {
            return Point2D.Length;
        }
    }
}
