using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_05_Estruturas_Decisao
    {
        static void NotMain(string[] args)
        {
            float salario_1 = 1000.0f, salario_2 = 1000.1f;
            if (salario_1 == salario_2) Console.WriteLine("Os Salarios são iguais");
            else Console.WriteLine("Os salarios são diferentes");
            string x = (salario_1 > salario_2) ? "Salário 1 é maior" : "Salário 2 é maior";
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}