using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public static class Area
    {
        //Вычисление площади фигуры без знания типа фигуры в compile-time
        public static double getArea(IFigure figure)
        {
            return figure.Area();
        }
    }
}
