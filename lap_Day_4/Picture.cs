using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_4
{
    internal class Picture
    {
        Shape[] shapes;

        public Picture(Shape[] _shapes)
        {
            shapes = _shapes; 
        }


        public void DisplayAllShapesArea()
        {
            foreach (Shape shape in shapes)
            {
                shape.Display();
            }
        }

    }
}
