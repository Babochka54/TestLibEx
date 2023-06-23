using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TestLib
{
    public class Triangle: IFigure
    {
        double edgeA;
        double edgeB;
        double edgeC;

        public Triangle(double A, double B, double C)
        {
            if (A > B + C || B > A + C || C > B + A)
            {
                throw new Exception("Сторона треугольника не должна превышать сумму других сторон");
            }
            else
            {
                edgeA = A;
                edgeB = B;
                edgeC = C;
            }
        }

        public bool isRightTriangle()
        {
            double maxEdge = edgeC, a = edgeA, b = edgeB;

            if (maxEdge - a > 0)
                Swap(ref maxEdge, ref a);
            if (maxEdge - b > 0)
                Swap(ref maxEdge, ref b);

            return Math.Pow(maxEdge,2) - Math.Pow(a,2) - Math.Pow(b,2) == 0;
        }

        public double Area()
        {
            double halfP = (edgeA + edgeB + edgeC) / 2;

            return Math.Sqrt(halfP * (halfP - edgeA) * (halfP - edgeB) * (halfP - edgeC)); ;
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = b;
            b = a;
            a = temp;
        }
    }
}
