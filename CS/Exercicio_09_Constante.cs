using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_09_Constante
    {
        enum Operacao { Soma, Subtracao, Multipliacao, Divisao }
        static void NotMain(string[] args)
        {
            //const float Pi = 3.1415f;
            //float raio = 4.2f;
            //float area = Pi * (raio * raio);
            //Console.WriteLine("Valor da area: "+area);

            float resultado = Calcula(5, 3, Operacao.Soma);
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("Resultado de 10 / 3 = " + Calcula(10, 3, Operacao.Divisao));
            Console.ReadKey();
        }
        static float Calcula(float operando1, float operando2, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Soma:
                    return operando1 + operando2;
                    break;
                case Operacao.Subtracao:
                    return operando1 - operando2;
                    break;
                case Operacao.Multipliacao:
                    return operando1 * operando2;
                    break;
                case Operacao.Divisao:
                    return operando1 / operando2;
                    break;
                default:
                    return 0;
                    break;
            }
        }

    }
}
