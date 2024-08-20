using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_4
{
    internal class Square : Rectangle
    {
        private int SideLength;
        public Square(Point2D topLeft, int _SideLength) : base(topLeft, new Point2D(topLeft.x + _SideLength, topLeft.y + _SideLength))
        {
            if (_SideLength <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero");
            }

            SideLength = _SideLength;
        }


        public override void Display()
        {
            Console.WriteLine($"This Shape ( Square ) , The area of the Square is = {CalculateArea()}");
        }
    }
}
