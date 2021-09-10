using System;
using Geom.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Shapes.Lines
{
    public class HorizontalLine : Line
    {
        public HorizontalLine(int x,int xLast,int y, char symb = Point.DefaultSymbol)
        {
            if (x > xLast || x<0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = x; i <= xLast; i++)
            {
                Points.Add(new Point(i,y));
            }
        }

    }
}
