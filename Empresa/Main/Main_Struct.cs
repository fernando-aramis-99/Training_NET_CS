using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    class Main_Struct
    {
        static void NotMain(string[] args)
        {
            string a; int b;
            Struct[] S = new Struct[10];
            //Console.Write("Digite um nome: "); a = Console.ReadLine();
            //Console.WriteLine("Digite uma idade: "); b = int.Parse(Console.ReadLine());
            //S[0].newcad(a, b);
            S[0].newcad("Andressa", 23);
            Console.ReadKey();
        }
    }
}
