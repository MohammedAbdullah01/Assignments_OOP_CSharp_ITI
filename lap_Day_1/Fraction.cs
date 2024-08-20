using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_1
{
    internal class Fraction
    {
         double extend;
         double place;

        public Fraction(double _extend, double _place)
        {
            extend = _extend;
            place = _place;
        }

        public void display()
        {
            Console.WriteLine($"New Fraction = Extend ( {extend} ) \t Place ( {place} )");
        }

        public Fraction Add(Fraction f1 , Fraction f2)
        {
            double NewExtend = (f1.extend * f2.place) + (f2.extend * f1.place);
            double NewPlace = f1.place * f2.place;
            return new Fraction(NewExtend , NewPlace);

        }
    }
}
