using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    //classes : Funcionario | Vendedor | Administrativo
    //vendedor:funcionario:pessoa
    //administrativo:funcionario
    //Implementar Override e virtual
    //somente implementar os metodos em vendedor e administrativo
    //temos uma classe funcionario : pessoa2 e uma classe vendedor
    //Temos uma classe funcionario : pessoa2 com pelo menos um metodo getSalario()
    //esta classe deve ter o seguinte construtor > public Funcionario (string cargo, decimal salario)
    //getsalario retorna o salario do funcionario
    //mas se for vendedor salario + comissao 10% (salario * 1.1)

    class Atividade_Aula_10
    {
        static void notMain(string[] args)
        {
            Funcionario V = new Funcionario("Fernando", "Colque", "Vendedor", 1500);
            Console.WriteLine(V.Nome);
            Console.ReadKey();
        }
    }
}