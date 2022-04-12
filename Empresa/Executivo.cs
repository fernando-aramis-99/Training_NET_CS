using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Executivo
    {
        public string _Codigo { get; set; }
        public string _Nome { get; set; }
        public decimal _Salario { get; set; }
        public decimal Bonus { get; set; }

        public Executivo(string codigo, string nome, decimal salario, decimal valor2)
        {
            _Codigo = codigo;
            _Nome = nome;
            _Salario = salario;
            this.Bonus = valor2;
        }
    }
}

