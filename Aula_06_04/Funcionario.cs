using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_04
{
    class Funcionario
    {
        public String Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
        public Empresa empresa { get; set; }
    }
}