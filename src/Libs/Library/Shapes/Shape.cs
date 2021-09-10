using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Shapes
{
    public abstract class Shape
    {
        public virtual IList<Point> Points { get; set; }

        protected Shape()
        {
            Points = new List<Point>();
        }

        

        public virtual void Draw()
        {
            foreach (var point in Points) point.Draw();
        }
    }
}
