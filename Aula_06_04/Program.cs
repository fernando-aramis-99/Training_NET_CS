using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //F9 - Criar BreakPoint
            //F10 - Debugar Codigo com os Breaks
            //selecionando na lateral das linhas se criam breaks
            var empresa = new Empresa() //Classe: entidade que por si só não tem sentido, passa a ter quando se usa
                                        //Atributo: campo da classe
                                        //Objeto: classe instanciada
            {
                RazaoSocial = "XPTO Ltda.",
                NomeFantasia = "Tabajara"
            };
            var funcionario1 = new Funcionario() { Nome = "Bruna", Salario = 1000, Cpf = "123" };
            var funcionario2 = new Funcionario() { Nome = "Bruno", Salario = 500, Cpf = "321" };
            var funcionario3 = new Funcionario() { Nome = "Barbara", Salario = 1000, Cpf = "213" };
            empresa.funcionarios.Add(funcionario1);
            empresa.funcionarios.Add(funcionario2);
            empresa.funcionarios.Add(funcionario3);

            foreach (var funcionario in empresa.funcionarios)
            {
                Console.WriteLine("Nome: {0} Cpf: {1}", funcionario.Nome, funcionario.Cpf);
            }

            Console.ReadKey();
        }
    }
}
