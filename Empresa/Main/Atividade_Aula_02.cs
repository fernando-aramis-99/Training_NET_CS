using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    class Atividade_Aula_02
    {
        static void NotMain(string[] args)
        {
            Conta01 conta = new Conta01("João Silva", true, 50000);

            Console.WriteLine(conta.NomeTitular + "\t" + conta.Saldo);
            Console.ReadKey();
        }
    }
}
