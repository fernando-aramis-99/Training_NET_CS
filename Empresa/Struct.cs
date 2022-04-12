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
    class Struct
    {
        public void newcad(string a, int b)
        {
            //Cadastro[] c = new Cadastro[10];
            //c(a, b);
            //Console.WriteLine("{0} - {1}", c.getN(), c.getI());
        }
        public void a()
        {
            Console.WriteLine("");
        }
        struct Cadastro
        {
            private string nome { get; set; }
            private int idade { get; set; }

            public Cadastro(string a, int b, int c)
            {
                nome = a;
                idade = b;
            }
            //public string getN() { return nome[]; }
            //public int getI() { return idade[]; }
        }

    }
}