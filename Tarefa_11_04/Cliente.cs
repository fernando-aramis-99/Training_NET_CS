using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_11_04
{
    class Cliente
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Cliente() { }
        public Cliente(string nome, decimal salario) : this()
        {
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
