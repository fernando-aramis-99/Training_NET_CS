using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public abstract class FiguraGeometrica
    {
        private const float PI = 3.14F;
        private float _Lado { get; set; }
        private float _Area { get; set; }
        private float _Perimetro { get; set; }
        public FiguraGeometrica()
        {

        }
        public float GetPI()
        {
            return PI;
        }

        public virtual void CSetPerimetro(float Raio)
        {
            this._Perimetro = Raio;
        }
        public virtual void QSetPerimetro(float LadoA, float LadoB)
        {
            this._Perimetro = LadoA + LadoB;
        }
        public virtual void SetArea(float Area)
        {
            this._Area = Area;
        }
        public virtual float GetPerimetro()
        {
            return _Perimetro;
        }
        public virtual float GetArea()
        {
            return _Area;
        }
    }
}

//switch (type)
//{
//    case 1: /* Circulo */
//        _Perimetro = 2 * PI * ladoA;
//        break;
//    case 2: /* Quadrilatero */
//        _Perimetro = (2 * ladoA) + (2 * ladoB);
//        break;
//    case 3: /* Triangulo */
//        _Perimetro = ladoA + ladoB + ladoC;
//        break;
//    case 4: /* Losango */
//        _Perimetro = ladoA + ladoB + ladoC + LadoD;
//        break;
//    case 5: /* Trapezio */
//        _Perimetro = ladoA + ladoB + ladoC + LadoD;
//        break;
//    default: /* Erro */
//        Console.WriteLine("\n! Falha na operação !");
//        break;
//}
