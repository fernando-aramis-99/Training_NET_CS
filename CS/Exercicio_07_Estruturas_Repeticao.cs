using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_07_Estruturas_Repeticao
    {
        static void NotMain(string[] args)
        {
            int tabuada = 3;
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
                i++;
            }

            tabuada++; i = 0; Console.WriteLine();
            do
            {
                Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
                i++;
            } while (i <= 10);

            tabuada++; Console.WriteLine();

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
            }

            tabuada++; Console.WriteLine();

            for (i = 0; i <= 10; i++)
            {
                if (i == 6) continue;
                Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
            }
            Console.ReadKey();

        }
    }
}
