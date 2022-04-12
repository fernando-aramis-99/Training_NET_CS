using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public string NomeCliente;
        public string NumeroConta;
        public decimal Saldo;
        public decimal Especial;
        List<Contrato> contrato = new List<Contrato>();

    }
}