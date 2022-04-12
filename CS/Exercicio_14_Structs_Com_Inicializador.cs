using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_14_Structs_Com_Inicializador
    {
        public struct Formacao
        {
            public string nome;
            public float valor;
            public string instrutor;
            public int matriculas;

            public Formacao(string pNome, float pValor, string pInstrutor) // Structs não podem ter construtores sem parametros
            {
                nome = pNome;
                valor = pValor;
                instrutor = pInstrutor;
                matriculas = 0;
            }
        }

        static void NotMain(string[] args)
        {
            Formacao f = new Formacao("C# Fundamentos", 123.45F, "André Camillo");
            Console.WriteLine(f.nome);
            Console.ReadKey();
        }

    }
}