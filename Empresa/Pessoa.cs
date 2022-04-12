using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public int Idade { get; private set; }

        public string GetNome() { return nome; }

        public string GetSobrenome() { return sobrenome; }

        public string GetNomeCompleto() { return nome + " " + sobrenome; }

        public void SetNome(string a) { this.nome = a; }

        public void SetSobrenome(string b) { this.sobrenome = b; }

        public void SetIdade(int c)
        {
            if (c < 1)
                throw new ArgumentOutOfRangeException("idade");
            else
                this.idade = c;
        }

    }
}
