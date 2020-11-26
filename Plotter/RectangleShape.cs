using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotter
{
    class RectangleShape : Shape, IShape
    {
        public double edge1 { get; set; }
        public double edge2 { get; set; }

        public RectangleShape(double edge1, double edge2)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
        }

        public double CalculateArea()
        {
            return edge1 * edge2;
        }

        public double CalculatePerimeter()
        {
            return 2 * (edge1 + edge2);
        }
    }
}
