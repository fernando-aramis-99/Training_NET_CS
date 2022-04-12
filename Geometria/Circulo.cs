using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Circulo : FiguraGeometrica
    {
        public override void CSetPerimetro(float Raio)
        {
            base.CSetPerimetro(Raio*2*GetPI());
        }
    }
}

