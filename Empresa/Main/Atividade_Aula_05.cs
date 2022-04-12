using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    class Atividade_Aula_05
    {
        static void notMain(string[] args)
        {
            var professor = new Executivo("11111111", "Camilo", 10000, 10000);
            var instrutor = new Instrutor("12345678", "Gustavo", 1000, ".NET");
            var aula = new Aula("Aula .NET", "Webex", new DateTime(31, 03, 2022));
        }
    }
}