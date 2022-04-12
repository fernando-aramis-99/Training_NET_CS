using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_15_Conversoes_Tipos
    {
        static void NotMain(string[] args)
        {
            int idade = 10;

            short salario = 1234;
            int salario2 = salario; // Conversão Implicita - limitado pela capacidade dos tipos

            float precoLivro = 90.52F;
            int precoLivroInteiro = (int)precoLivro; //Conversão sujeita a perda de dados

            string numeroEmString = "1234,56";
            float valor = float.Parse(numeroEmString); // Tipo (I) -> Tipo (F)
            string numero2 = valor.ToString(); // Numero -> String

            double valor2 = Convert.ToDouble(numeroEmString);

            DateTime dataContratacao = DateTime.Parse("22/03/2022"); // ou Convert.ToDateTime("");
            Console.WriteLine("Data de contratação: " + dataContratacao);

            Console.ReadKey();
        }

    }
}
