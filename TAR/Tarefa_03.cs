using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{

    class Tarefa_03
    {
        static void NotMain(string[] args)
        {
            float peso, altura, imc;
            Console.WriteLine("*** Indice de Massa Corporal ***");

            Console.Write("Digite o seu peso: "); peso = float.Parse(Console.ReadLine());
            Console.Write("\nDigite a sua altura: "); altura = float.Parse(Console.ReadLine());

            imc = calculo(peso, altura);

            Console.WriteLine("O seu IMC é: {0}\nSeu estado de saude é: {1}", imc.ToString("N2"), estado(imc.ToString("N0")));
            Console.WriteLine("O Tipo de dados Utilizado é: " + peso.GetType());

            Console.ReadKey();
        }

        static float calculo(float a, float b) { return (a / (b * b)); }
        static string estado(string a)
        {
            switch (a)
            {
                case "16": return "Muito abaixo do peso"; break;
                case "19": return "Abaixo do peso"; break;
                case "25": return "Peso normal"; break;
                case "29": return "Acima do peso"; break;
                case "34": return "Obesidade tipo I"; break;
                case "39": return "Obesidade tipo II"; break;
                case "45": return "Obesidade tipo III - Mórbida"; break;
                default: return "Preocupante !"; break;
            }
        }

    }
}
