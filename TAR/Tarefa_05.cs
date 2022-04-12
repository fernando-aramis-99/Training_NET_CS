using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{
    class Tarefa_05
    {
        /* Crie um programa que armazene 10 notas em um array.
        O programa deve ler o array e imprimir os seguintes resultados:
        1) Exibir a maior nota do array
        2) Exibir a menor nota do array
        3) Exibir a soma das notas pares
        4) Exibir a soma das notas ímpares
        5) Dizer se o número 5 existe no array */
        static void NotMain(string[] args)
        {
            int[] boletim = new int[10];
            int maior = -1, menor = 999, somaP = 0, somaI = 0;
            string five = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nDigite a nota :  ", i);
                boletim[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < 10; j++)
            {
                if (boletim[j] > maior) maior = boletim[j];
                else if (boletim[j] < menor) menor = boletim[j];
                if (j % 2 == 0) somaP += boletim[j];
                else somaI += boletim[j];
                if (five == string.Empty)
                    if (boletim[j] == 5) five = "O numero 5 Existe no array !";
            }

            Console.WriteLine("\nA maior nota do boletim é: {0}\nA menor nota do boletim é: {1}", maior, menor);
            Console.WriteLine("\nA soma das notas: [ {0} - Pares ]\t[ {1} - Impares ]\n{2} ", somaP, somaI, five);
            Console.ReadKey();
        }
    }
}