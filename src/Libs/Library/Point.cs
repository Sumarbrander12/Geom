using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom
{
    public struct Point
    {
        public const char DefaultSymbol = 'X';
        public int X, Y;
        public char Symbol;
        public Point(int x, int y, char c = DefaultSymbol)
        {
            X = x;
            Y = y;
            Symbol = c;
        }

        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(Symbol);
        }
    }
}
