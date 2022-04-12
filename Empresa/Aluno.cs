using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public Aluno(string CPF, string nome, string curso)
        {
            this.Curso = curso;
        }
    }
}