using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Administrativo : Funcionario
    {
        public DateTime _DataAdmissao { get; set; }
        public DateTime _DataDemissao { get; set; }

        public Administrativo(string nome, string sobrenome, string cargo, decimal salario)
        {
            new Funcionario(nome, sobrenome, cargo, salario);
        }

        public DateTime DataAdmissao
        {
            set
            {
                this._DataAdmissao = value;
            }
            get
            {
                return _DataAdmissao;
            }
        }
        public DateTime DataDemissao
        {
            set
            {
                this._DataDemissao = value;
            }
            get
            {
                return _DataDemissao;
            }
        }
    }
}

