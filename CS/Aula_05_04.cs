using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Aula_05_04
    {
        static void NotMain(string[] args)
        {
            int[] numeros = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            var consulta =
                from num in numeros
                where (num % 2) == 0
                select num;
            foreach (int num in consulta)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}