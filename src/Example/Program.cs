using System;
using static System.Console;
using Geom.Shapes.Lines;
using Geom.Shapes;
using Geom;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10,10);
            point.Draw();
            Line line = new HorizontalLine(11,20,5);
            line.Draw();
            Line line2 = new VerticalLine(5,20,15);
            line2.Draw();
            ReadLine();
            
        }
    }
}
