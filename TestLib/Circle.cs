using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Circle: IFigure
    {
        double radius;
        public Circle(double Radius)
        {
            radius = Radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
