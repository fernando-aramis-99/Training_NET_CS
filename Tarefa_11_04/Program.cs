using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercício 1:
//-Criar uma classe chama Cliente com os seguintes atributos, Nome e Salário
//- Instanciar uma lista de clientes List<Cliente> e popular a lista com vários clientes new Cliente() { XXX }
//- Exibir os clientes 3 clientes com maior salário ordenados por nome
//Exercício 2:
//-Criar 2 arrays ex:
//  int[] conjunto1 = new int[] { 10, 20, 30, 40, 50, 10 };
//int[] conjunto2 = new int[] { 10, 15, 20, 25, 30 };
//Pesquisar e utilizar os métodos Except, Intersect e Union
//Obs: Em ambos os exercícios fica livre o uso da sintaxe por método e sintaxe por consulta.

namespace Tarefa_11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente { Nome = "Fernando Aramis", Salario = 2500.55m });
            clientes.Add(new Cliente { Nome = "João Vitor", Salario = 3654.87m });
            clientes.Add(new Cliente { Nome = "Andressa Araujo", Salario = 3499.99m });
            clientes.Add(new Cliente { Nome = "Eduardo Batista", Salario = 1350.36m });
            clientes.Add(new Cliente { Nome = "Felipe Nogueira", Salario = 2740.45m });
            clientes.Add(new Cliente { Nome = "Giovana Siqueira", Salario = 3764.76m });
            clientes.Add(new Cliente { Nome = "Samuel Lacerda", Salario = 2945.12m });
            clientes.Add(new Cliente { Nome = "Johnny Silva", Salario = 2789.17m });

            var ConsultaSalario =
                from Cliente in clientes
                orderby Cliente.Salario 
                descending select new { nome = Cliente.Nome, salario = Cliente.Salario };
            var consul =
                from item in ConsultaSalario.Take(3)
                orderby item.nome
                select item;

            foreach (var item in consul)
            {
                Console.WriteLine("Nome: {0}, Salario: {1}", item.nome, item.salario);
            }
            
            int[] conjunto1 = new int[] { 10, 20, 30, 40, 50, 10 };
            int[] conjunto2 = new int[] { 10, 15, 20, 25, 30, 57 };

            Console.Write("\nConjunto A: ");
            for (int i = 0; i < conjunto1.Length; i++)
            {
                Console.Write(" " + conjunto1[i]);
            }
            
            Console.Write("\nConjunto B: ");
            for (int i = 0; i < conjunto2.Length; i++)
            {
                Console.Write(" " + conjunto2[i]);
            }

            IEnumerable<int> uniao = conjunto1.AsQueryable().Union(conjunto2);
            Console.Write("\nUnião:");
            foreach (var item in uniao)
            {
                Console.Write(" "+item);
            }

            IEnumerable<int> intersecao = conjunto1.Intersect(conjunto2);
            Console.Write("\nIntersecção:");
            foreach (var item in intersecao)
            {
                Console.Write(" " + item);
            }

            IEnumerable<int> exceptA = conjunto1.AsQueryable().Except(conjunto2);
            Console.Write("\nExeção (A para B):");
            foreach (var item in exceptA)
            {
                Console.Write(" " + item);
            }

            IEnumerable<int> exceptB = conjunto2.AsQueryable().Except(conjunto1);
            Console.Write("\nExeção (B para A):");
            foreach (var item in exceptB)
            {
                Console.Write(" " + item);
            }

            Console.ReadKey();
        }
    }
}
