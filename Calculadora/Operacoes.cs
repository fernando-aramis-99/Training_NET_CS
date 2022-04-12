using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public Operacoes() { }
        public float Soma(float a, float b) { return a + b; }
        public float Resta(float a, float b) { return a - b; }
        public float Mult(float a, float b) { return a * b; }
        public float Div(float a, float b) { return a / b; }
        public string DefParidade(float a)
        {
            string r = (a % 2 == 0) ? "Par" : "Impar";
            return r;
        }
        public double Pot(double a, double b) { return Math.Pow(a, b); }
        public double Rad(double a) { return Math.Sqrt(a); }
        public static int Fat(int a)
        {
            if (a == 1) { return 1; }
            else { return a * Fat(a - 1); }
        }
    }
}