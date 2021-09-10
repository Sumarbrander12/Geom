using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Shapes.Lines
{
     public class VerticalLine : Line
    {
        public VerticalLine(int y, int yLast, int x, char symb = Point.DefaultSymbol)
        {
            if (y > yLast || y < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = y; i <= yLast; i++)
            {
                Points.Add(new Point(x, i));
            }
        }

    }
}
