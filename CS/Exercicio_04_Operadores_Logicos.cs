using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_04_Operadores_Logicos
    {
        static void NotMain(string[] args)
        {
            bool sol = true, vento = false, ferias = true;
            int salario = 15000;

            if (sol && vento) Console.WriteLine("Está sol e também está ventando");
            if (sol && !vento) Console.WriteLine("Está sol e não está ventando");
            if (sol || vento) Console.WriteLine("Está sol ou está ventando");
            if (sol && ferias && salario > 10000) Console.WriteLine("Vamos Viajar ?");
            if (sol ^ ferias) Console.WriteLine("XOR = True");
            else Console.WriteLine("XOR = False");
            Console.ReadKey();

        }
    }
}
