using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_2
{
    internal class Fraction
    {
        int extend;
        int place;

        public Fraction(): this(0,0)
        {

        }
        public Fraction (int _extend) : this(_extend, 0)    
        {

        }
        public Fraction(int _extend ,int _place)
        {
            this.extend = _extend;  
            this.place = _place;
        }


        public Fraction Add(Fraction f2)
        {
            int NewExtend = (extend * f2.place) +  (f2.extend * place);
            int NewPlace = place * f2.place;

            return new Fraction(NewExtend, NewPlace);
        }


        public void Display()
        {
            Console.WriteLine($"First Fraction\nextend = ({extend})\tplace = ({place})");
        }
    }
}
