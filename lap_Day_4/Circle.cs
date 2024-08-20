using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_4
{
    internal class Circle : Shape
    {
        public Point2D Center { get; private set; }
        public double Radius { get; private set; }


        public Circle(Point2D center, double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero");
            }

            Center = center;
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Display()
        {
            Console.WriteLine($"This Shape ( Circle ) , The area of the circle is = {CalculateArea()}");
        }


    }
}
