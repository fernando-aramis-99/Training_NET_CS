using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio_14_Structs
    {
        static void NotMain(string[] args)
        {
            Curso curso;
            curso.nome = "C# Fundamentos";
            curso.valor = 123.45F;
            curso.instrutor = "André Camillo";
            curso.matriculas = 15;
            Console.WriteLine("O curso {0} possui valor de {1}", curso.nome, curso.valor);
            Console.WriteLine(curso);
            Console.ReadKey();
        }

        public struct Curso
        {
            public string nome;
            public float valor;
            public string instrutor;
            public int matriculas;
        }

        public override string ToString()
        {
            return "";// "O curso " + nome + " possui o valor "+valor;
        }
    }
}
