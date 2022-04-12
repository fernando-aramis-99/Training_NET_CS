using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Funcionario : Pessoa2
    {

        private string _Cargo { get; set; }
        private decimal _Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string cargo, decimal salario) : this()
        {
            this._Cargo = cargo;
            this._Salario = salario;
        }
        public Funcionario(string nome, string sobrenome, string cargo, decimal salario) : this(cargo, salario)
        {
            new Pessoa2(nome, sobrenome);
            this._Cargo = cargo;
            this._Salario = salario;
        }

        public string Cargo
        {
            set
            {
                this._Cargo = value;
            }
            get
            {
                return _Cargo;
            }
        }
        virtual public decimal Salario
        {
            set
            {
                this._Salario = value;
            }
            get
            {
                return _Salario;
            }
        }
        //public override string Nome { get => base.Nome; set => base.Nome = value; }
        public override string Nome
        {
            set
            {
                base.Nome = value;
            }
            get
            {
                return base.Nome;
            }
        }

        public override string ToString()
        {
            return Nome + " " + _Cargo + " " + _Salario.ToString("F2");
        }


        public override string Sobrenome { get => base.Sobrenome; set => base.Sobrenome = value; }
        public override DateTime Nascimento { get => base.Nascimento; set => base.Nascimento = value; }
    }
}
