using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{
    class Tarefa_04
    {
        // faça um algoritmo que receba uma data no formato (DIA; MES; ANO; HORA MIN; SEG)
        // retorne uma msg informando se esta data é de uma ano bissexto
        // informe a data a uma semana atrás
        // informar se eh final de semana
        static void Main(string[] args)
        {
            int D, M, A, H, MN, S;
            string ano = string.Empty, dia = string.Empty;

            Console.Write("Informe o Dia: ");
            D = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Mês: ");
            M = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Ano: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Hora: ");
            H = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Minuto: ");
            MN = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Segundo: ");
            S = int.Parse(Console.ReadLine());

            DateTime data = new DateTime(A, M, D, H, MN, S);

            if ((A % 4 == 0) && (A % 10 != 0)) { ano = "Bissexto"; }

            else if ((A % 4 == 0) && (A % 100 == 0) && (A % 400 == 0)) { ano = "Bissexto"; }

            else { ano = "Normal"; }

            if ((data.DayOfWeek.ToString().Equals("Sunday")) || (data.DayOfWeek.ToString().Equals("Saturday"))) { dia = "final de semana"; }

            else { dia = "dia útil da semana"; }

            Console.WriteLine("\n{0}\nEsta data pertence a um ano {1}\nÉ {2} - {3}\nHá semana atrás: {4}", data, ano, dia, data.DayOfWeek, data.AddDays(-7));

            Console.ReadKey();
        }
    }
}
