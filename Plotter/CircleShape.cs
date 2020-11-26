using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotter
{
    class CircleShape : Shape, IShape
    {
        public double radius { get; set; }

        public CircleShape(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
