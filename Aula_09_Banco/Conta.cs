using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Mensagem { get; set; }

        public Conta(int numero, decimal saldo) //ctor cria construtor
        {
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public virtual void Saca(decimal valor)
        {
            if (valor < 0) // O Exception engloba todas as execoes
            {
                throw new ArgumentException();
            }
            else if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            this.Saldo -= valor;
            this.Mensagem = "Saque realizado com sucesso!";
        }
        public void Saca(decimal valor, int numero)
        {
            if (valor < 0) // O Exception engloba todas as execoes
            {
                throw new ArgumentException();
            }
            else if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            this.Saldo -= valor;
            this.Mensagem = $"Saque da conta {numero} realizado com sucesso!"; //$ ajuda a enxertar valores em string
        }
    }
}