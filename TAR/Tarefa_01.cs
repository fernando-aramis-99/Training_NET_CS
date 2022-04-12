using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{
    class Tarefa_01
    {
        static void Main(string[] args)
        {
            float peso, altura;
            Console.WriteLine("*** Indice de Massa Corporal ***");
            Console.Write("Digite o seu peso: "); peso = float.Parse(Console.ReadLine());
            Console.Write("\nDigite a sua altura: "); altura = float.Parse(Console.ReadLine());
            Console.WriteLine("O seu IMC é: " + (peso / (altura * altura)));
            Console.WriteLine("O Tipo de dados Utilizado é: " + peso.GetType());
            Console.ReadKey();
        }
    }
}
