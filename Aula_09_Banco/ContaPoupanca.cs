using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Banco
{
    public class ContaPoupanca : Conta
    {
        //para realizar override, implementar virtual 

        public double Rendimento { get; set; }

        public ContaPoupanca(double rendimento) : base(1, 500) // chamou o contrutor da classe pai primeiro
        {
            this.Rendimento = rendimento;
        }

        public override void Saca(decimal valor)
        {
            base.Saca(valor + 0.10m); //o base é para ter acesso as opcoes da classe conta
        }
    }
}