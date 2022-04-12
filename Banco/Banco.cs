using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        public string Nome = "Itaú";
        public static List<Conta> conta = new List<Conta>();
        public static Dictionary<int, List<Conta>> Dconta = new Dictionary<int, List<Conta>>();
        public static List<Contrato> contrato = new List<Contrato>();
    }
}
