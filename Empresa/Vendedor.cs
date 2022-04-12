using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Vendedor : Funcionario
    {
        public decimal _Comissao { get; set; }
        public const decimal COMISSAO_PADRAO = 10;

        public Vendedor(string nome, string sobrenome, string cargo, decimal salario)
        {
            new Funcionario(nome, sobrenome, cargo, salario);
        }

        public override decimal Salario { get => base.Salario; set => base.Salario = (value + (value / 10)); }

        public decimal Comissao
        {
            set
            {
                this._Comissao = value;
            }
            get
            {
                return _Comissao;
            }
        }
    }
}
