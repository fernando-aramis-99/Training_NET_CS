using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{
    class Tarefa_03_2
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
                case "10":
                case "11":
                case "12":
                case "13":
                case "14":
                case "15":
                case "16": return "Muito abaixo do peso"; break;
                case "17":
                case "18":
                case "19": return "Abaixo do peso"; break;
                case "20":
                case "21":
                case "22":
                case "23":
                case "24":
                case "25": return "Peso normal"; break;
                case "26":
                case "27":
                case "28":
                case "29": return "Acima do peso"; break;
                case "30":
                case "31":
                case "32":
                case "33":
                case "34": return "Obesidade tipo I"; break;
                case "35":
                case "36":
                case "37":
                case "38":
                case "39": return "Obesidade tipo II"; break;
                case "40":
                case "41":
                case "42":
                case "43":
                case "44":
                case "45": return "Obesidade tipo III - Mórbida"; break;
                default: return "Preocupante !"; break;
            }
        }

    }
}
