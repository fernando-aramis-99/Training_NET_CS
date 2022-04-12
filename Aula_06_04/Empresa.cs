using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_04
{
    class Empresa
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public List<Funcionario> funcionarios { get; set; }

        public Empresa()
        {
            funcionarios = new List<Funcionario>();
        }
    }
}