using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_3
{
    internal class Square : Rectangle
    {
        public int SideLength;
        public Square(Point2D topLeft, int _SideLength) : base(topLeft , new Point2D(topLeft.x + _SideLength , topLeft.y + _SideLength))
        {
            SideLength = _SideLength;
        }

    }
}
