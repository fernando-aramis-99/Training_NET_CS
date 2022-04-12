using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_06_Escopo_Variaveis
    {
        static void NotMain(string[] args)
        {
            float salario = 2000f;
            if (salario > 1000)
            {
                float reajuste = salario * 0.1f;
                salario += reajuste;
                Console.WriteLine("Valor do reajuste: " + reajuste);
                Console.WriteLine("Novo salário: " + salario);
            }
            Console.ReadKey();

        }
    }
}