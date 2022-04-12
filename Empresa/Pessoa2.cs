using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Pessoa2
    {
        //static public int CountInstancias;
        //public int Idade { get; set; }

        private DateTime _nascimento;
        private string _Nome { get; set; }
        private string _Sobrenome { get; set; }
        internal protected int Idade;

        public Pessoa2() { }

        public Pessoa2(string nome, string sobrenome) : this()
        {
            this._Nome = nome;
            this._Sobrenome = sobrenome;
        }

        public Pessoa2(string nome, string sobrenome, DateTime nascimento) : this(nome, sobrenome)
        {
            this._Nome = nome;
            this._Sobrenome = sobrenome;
            this._nascimento = nascimento;
        }

        public virtual string Nome
        {
            set
            {
                this._Nome = value;
            }
            get
            {
                return _Nome;
            }
        }
        public virtual string Sobrenome
        {
            set
            {
                this._Sobrenome = value;
            }
            get
            {
                return _Sobrenome;
            }
        }

        public int AnosCompletos
        {
            get
            {
                return (DateTime.Now.Year - _nascimento.Year);
            }
        }

        public virtual DateTime Nascimento
        {
            set
            {
                this._nascimento = value;
            }
            get
            {
                return _nascimento;
            }
        }
        //public Pessoa2() { CountInstancias++; }
    }
}

