using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.SetNome("João");
            p.SetSobrenome("Silva");
            p.SetIdade(10);
            //p = null;  // seta o ponteiro da variavel a nulo
            /*Pessoa p2 = p; // Associamos o mesmo endereço à variavel p2
            p2.nome = "José";
            p2 e p1 possuem o mesmo endereço de memória
            as variaveis a serem alteradas afetarão
            a todas as referências */

            Console.WriteLine(p.GetNomeCompleto());
            Console.ReadKey();
        }
    }
}
