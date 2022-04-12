using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo : FiguraGeometrica
    {
        private double ladoA, ladoB, ladoC, semiPerimetro, area;
        //private FiguraGeometrica f = new FiguraGeometrica();
        public void SetTriangulo(double a, double b, double c)
        {
            ladoA = a;
            ladoB = b;
            ladoC = c;
        }
        //public override void GetArea()
        //{
        //    semiPerimetro = (ladoA + ladoB + ladoC) / 2;
        //    area = Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
        //    //return area;
        //}
    }
}