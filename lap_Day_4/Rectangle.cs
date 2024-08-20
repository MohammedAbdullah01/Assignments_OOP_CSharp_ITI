using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_4
{
    internal class Rectangle : Shape
    {
        protected Point2D point1 { get; private set; }
        protected Point2D point2 { get; private set; }

        public Rectangle(Point2D _point1, Point2D _point2)
        {
            point1 = _point1;
            point2 = _point2;
        }

        public override double CalculateArea()
        {
            double width = Math.Abs(point2.x - point1.x) , height = Math.Abs(point2.y - point1.y);
            return width * height;
        }


        public override void Display()
        {
            Console.WriteLine($"This Shape ( Rectangle ) , The area of the Rectangle is = {CalculateArea()}");
        }
    }
}
