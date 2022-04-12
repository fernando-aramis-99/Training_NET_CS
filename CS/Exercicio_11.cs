using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_11
    {
        static void NotMain(string[] args)
        {
            string frase = "    Hoje é um excelente dia para estudar C#         ";
            int tamanhoFrase = frase.Length;
            //Console.WriteLine(string.Format("Tamanho da frase: {0} caracteres", frase.Length));
            //Console.WriteLine(frase.TrimStart()+ "///"); // Trim serve para tratar tamanho !! - Start: retira espaço no inicio / End: retira espaço no final da string      //
            //Console.WriteLine(frase.TrimEnd()+ "///");
            string novaFrase = frase.Trim();
            frase = frase.Insert(3, "**");
            string loginDB = "SANGUST";
            string loginTL = "SanGust";
            //Console.WriteLine(frase.Contains("#")); // Retorna em bool se contém certo caractere / cadeia de caracteres
            //Console.WriteLine(novaFrase==frase);
            //Console.WriteLine(novaFrase.Equals("Hoje")); // realiza a verificação de igualdade / aceita qualquer parametro de comparação
            //Console.WriteLine(frase.Insert(4, "---")); // Devolve a string tratada, mas não a altera
            //Console.WriteLine(frase);
            //Console.WriteLine(frase.IndexOf("#")); // Procura via char e devolve a posição do mesmo
            //Console.WriteLine(frase[44]); // Resultado da busca Reversa
            //Console.WriteLine(frase.ToUpper());
            //Console.WriteLine(frase.ToLower());
            Console.WriteLine(loginTL.ToUpper().Trim().Equals(loginDB));
            Console.ReadKey();
        }
    }
}