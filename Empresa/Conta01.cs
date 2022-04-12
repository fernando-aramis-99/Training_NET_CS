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
    class Conta01
    {
        private const float LIMITE_PADRAO = 1000;
        public string NomeTitular { get; set; }
        public float Saldo { get; set; }
        public bool Especial { get; set; }
        public float Limite { get; set; }

        private Decimal _saldo;

        public Conta01() { }
        public Conta01(string nome)
        {
            Console.WriteLine("Construtor 1");
            NomeTitular = nome;
            Saldo = 0;
            Especial = false;
            Limite = 0;
        }

        public Conta01(string nome, float saldo) : this(nome) // 
        {
            Console.WriteLine("Construtor 2");
            NomeTitular = nome;
            this.Saldo = saldo;
            Especial = false;
            Limite = 0;
        }
        public Conta01(string nome, bool especial)
        {
            Console.WriteLine("Construtor 3");
            this.NomeTitular = nome;
            this.Saldo = 0;
            this.Especial = especial;
        }
        public Conta01(string nome, bool especial, float saldo) : this(nome, saldo)
        {
            Console.WriteLine("Construtor 4");
            this.NomeTitular = nome;
            this.Saldo = saldo;
            this.Especial = especial;
            this.Limite = especial ? LIMITE_PADRAO : 0;
        }

        //public decimal _saldo { }
    }
}