using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotter
{
    class Shape : IShape
    {
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public string Print(double area, double perimeter)
        {
            return "Perimeter : " + area + " Area : " + perimeter;
        }
    }
}
