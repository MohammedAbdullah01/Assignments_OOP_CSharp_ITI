namespace lap_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point3D point1 = new Point3D (10, 3, 5);
            Point3D point2 = new Point3D (10, 3, 5);

            //Overload == operator
            if (point1 == point2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Fraction fraction1 = new Fraction(10, 8);

            // Implicit
            Fraction fraction2 = fraction1 + 5;
            Console.WriteLine(fraction2.place); // 13

            // Implicit
            Fraction fraction3 = 35;
            Console.WriteLine(fraction3.extend); // 0
            Console.WriteLine(fraction3.place); // 35

            //Explicit
            int numFraction = (int)fraction3;
            Console.WriteLine(numFraction); // 35


        }
    }
}
