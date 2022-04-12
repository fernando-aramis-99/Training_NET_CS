using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_06_Escopo_Variaveis_2
    {
        static void NotMain(string[] args)
        {
            float novoSalarioReajustado10PorCento(float salario)
            {
                float reajuste = 10f;
                float novoSalario = salario + (salario / 100 * reajuste);
                return novoSalario;
            }
            float meuSalario = 2000;
            Console.WriteLine("Meu novo salário: " + novoSalarioReajustado10PorCento(meuSalario));
            Console.ReadKey();

        }
    }
}