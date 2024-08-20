using System.Drawing;

namespace lap_Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(1, 2);

            Point2D point2 = new Point2D(4, 6);


            Rectangle rectangle1 = new Rectangle(point1, point2);


            Point2D squareTopLeft = new Point2D(3, 3);
            int sideLength = 4;

            Square square1 = new Square(squareTopLeft, sideLength);


            Point2D circleCenter = new Point2D(0, 0);
            double radius = 5.0;

            Circle circle1 = new Circle(circleCenter, radius);

            Shape[] shapes = new Shape[]{ rectangle1, square1, circle1 };

            Picture Pictures = new Picture(shapes);

            Pictures.DisplayAllShapesArea();

        }
    }
}
