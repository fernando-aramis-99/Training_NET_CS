using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Instrutor
    {
        public string CPF { get; set; }
        public string _nome { get; set; }
        public decimal Salario { get; set; }
        public string materia { get; set; }

        public Instrutor(string cPF, string nome, decimal salario, string materia)
        {
            CPF = cPF;
            _nome = nome;
            Salario = salario;
            this.materia = materia;
        }
    }
}

