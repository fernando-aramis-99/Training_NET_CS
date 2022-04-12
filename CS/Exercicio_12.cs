using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_12
    {
        static void NotMain(string[] args)
        {
            DateTime data1 = new DateTime(2020, 12, 18, 15, 11, 10);
            DateTime data2 = new DateTime(2020, 12, 18, 15, 11, 10); //new DateTime(2020, 12, 18);

            //Console.WriteLine("Data 1: "+ data1.DayOfWeek);
            //Console.WriteLine("Data 2: "+ data2.DayOfYear);
            //Console.WriteLine(data1.Equals(data2));
            //data1 = DateTime.Today; // Dia de Hoje
            //data2 = DateTime.Now; // +Hora Exata
            //Console.WriteLine(data1.ToString() +"\t"+ data2.ToString());
            //Console.WriteLine("Ano: "+ data1.Year);
            //Console.WriteLine("Mes: " + data1.Month);
            //Console.WriteLine("Dia: " + data1.Day);
            //Console.WriteLine("Hora: " + data1.Hour);

            StringBuilder s1 = new StringBuilder("AAAAAA");
            StringBuilder s2 = new StringBuilder("AAAAAA");
            Console.WriteLine(s1 == s2); // compara o valor do ponteiro
            Console.WriteLine(s1.Equals(s2)); // compara o conteudo da string


            Console.ReadKey();
        }
    }
}
