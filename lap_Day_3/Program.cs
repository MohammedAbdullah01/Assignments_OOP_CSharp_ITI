namespace lap_Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(5, 5);

            Point2D p2 = new Point2D(4, 6);

            //Line l1 = new Line();

            //l1.AddPoint2D(p1);
            //l1.AddPoint2D(p2);

            //Console.WriteLine(l1.GetLength());

            //Rectangle r1 = new Rectangle(p1 , p2);

            //Console.WriteLine(r1.CalculateArea()); // 0

            Square s1 = new Square(p1 , 4);

            Console.WriteLine(s1.CalculateArea()); // 30




        }
    }
}
