using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_10_String
    {
        static void NotMain(string[] args)
        {
            string nomeCurso = "Programação C# / .NET";
            float valorCurso = 123.456f;
            //DateTime date = "03-17-2022T00:00:00";
            string resultado = string.Empty;

            //resultado = "Valor do curso: " + valorCurso;
            resultado = string.Format("Valor do curso: {0}", valorCurso);
            resultado = string.Format("Valor do curso {0} e de: {1}", nomeCurso, valorCurso);
            resultado = string.Format("Valor do curso {0} e de: {1:C2}", nomeCurso, valorCurso);
            resultado = string.Format("Valor do curso e de: {1}", nomeCurso, valorCurso);
            resultado = string.Format("Em {0} valor do curso {1} e de: {2}", DateTime.Now, nomeCurso, valorCurso);

            Console.WriteLine(resultado);
            Console.WriteLine($"{valorCurso}");
            Console.ReadKey();
        }
    }
}