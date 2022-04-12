using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Saldo tratar os eventos sacar, depositar, traferir (Verificar o saldo antes);
//Permitir Agendamento de transacoes(Tranferencia, deposito)
//Tratar o caso do cliente especial (Se cliente especial limite = LIMITE_PADRAO ou maior
//<Limite = especial ? LIMITE_PADRAO : 0>)

namespace Empresa
{
    class Atividade_Conta
    {
        private DateTime data_Agendamento;

        //private Decimal _saldo;

        private const float LIMITE_PADRAO = 1000;
        private string NomeTitular { get; set; }
        private float Saldo { get; set; }
        private bool Especial { get; set; }
        private float Limite { get; set; }

        public Atividade_Conta() { }

        public Atividade_Conta(string iNome, float iSaldo) : this()
        {
            NomeTitular = iNome;
            Saldo = iSaldo;
            Especial = false;
            Limite = 0F;
        }
        public Atividade_Conta(string iNome, float saldo, bool iEspecial, float iLimite)
        {
            this.NomeTitular = iNome;
            this.Saldo = 0F;
            Especial = iEspecial;
            this.Limite = Especial ? iLimite : 0;
        }
        public Atividade_Conta(string iNome, float iSaldo, bool iEspecial) : this(iNome, iSaldo)
        {
            this.NomeTitular = iNome;
            this.Saldo = 0F;
            Especial = iEspecial;
            this.Limite = Especial ? LIMITE_PADRAO : 0;
        }

        public void Saque(float saque)
        {
            if ((saque <= this.Saldo) && (saque > 0))
            {
                this.Saldo -= saque;
            }
            else
            {
                Console.WriteLine("! Saldo Insufuciente, Operação Cancelada !");
            }
        }
        public void Deposito(float deposito)
        {
            if (deposito > 0)
            {
                this.Saldo += deposito;
            }
            else
            {
                Console.WriteLine("! Valor Incorreto, Operação Cancelada !");
            }
        }
        public void Transferencia(float transferencia)
        {
            if ((transferencia <= this.Saldo) && (transferencia > 0))
            {
                this.Saldo += transferencia;
            }
            else
            {
                Console.WriteLine("! Saldo Insufuciente, Operação Cancelada !");
            }
        }
        public float GetSaldo()
        {
            return Saldo;
        }
        public void Agendamento(int n, int m)
        {
            string a, b, c;
            data_Agendamento = DateTime.Now;
            Console.Write("\nDigite a data de pagamento\nDia: ");
            a = Console.ReadLine();
            Console.Write("\nMês: ");
            b = Console.ReadLine();
            c = Convert.ToString(data_Agendamento.Year);
            data_Agendamento = DateTime.Parse(a + "/" + b + "/" + c + " 08:00:00");
            Console.WriteLine("Operaçao realiada para o dia " + data_Agendamento);
        }
    }
}
