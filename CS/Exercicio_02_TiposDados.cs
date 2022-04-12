using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_02_TiposDados
    {
        static void notMain(string[] args)
        {
            int idade = 30;
            double salarioDouble = 1234.56D;
            float salario = 1234.56F;
            decimal salario_2 = 1234.56M; /*Mais Indicado Para Valores Monetários*/
            Console.WriteLine(salarioDouble);
            Console.ReadKey();
        }
    }
}
