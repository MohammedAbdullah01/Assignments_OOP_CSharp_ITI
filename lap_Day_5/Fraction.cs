
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_5
{
    internal class Fraction
    {
        public int extend { get; set; }
        public int place { get; set; }


        public Fraction(int _extend , int _place)
        {
            extend = _extend;
            place = _place;
            
        }


        public static Fraction operator+(Fraction fraction1 , Fraction fraction2)
        {
            Fraction result = new Fraction(0,0);
            result.extend = fraction1.extend + fraction2.extend;
            result.place = fraction1.place + fraction2.place;
            return result;
        }

        public static implicit operator Fraction(int number)
        {
            return new Fraction(0, number);
        }


        public static explicit operator int(Fraction fraction)
        {
            return fraction.place;
        }
    }
}
