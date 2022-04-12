using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Main
{
    class Atividade_Aula_08 : Atividade_Conta
    {
        //Saldo tratar os eventos sacar, depositar, traferir (Verificar o saldo antes);
        //Permitir Agendamento de transacoes(Tranferencia, deposito)
        //Tratar o caso do cliente especial (Se cliente especial limite = LIMITE_PADRAO ou maior
        //<Limite = especial ? LIMITE_PADRAO : 0>)
        static void NotMain(string[] args)
        {
            int A = 1, B = 1, esp = 0;
            string Nome = string.Empty;
            float Limite = 0, Saldo = 0, Saque = 0, Deposito = 0, Transferencia = 0;
            bool Especial = false;
            Atividade_Conta C = new Atividade_Conta();
            while (A != 0) // begin Main;
            {
                Console.WriteLine("BEM VINDO AO SISTEMA BANCÁRIO\n1 - [Criar / Alterar] Conta\n2 - Acessar Sistema De Atendimento Eletronico\n0 - Sair");
                Console.Write("Selecione a opção: ");
                A = int.Parse(Console.ReadLine());
                if (A == 1) // begin Conta;
                {
                    Console.WriteLine("GERENCIAMENTO DE CONTA");

                    Console.Write("\nDigite o Nome do Titular: ");
                    Nome = Console.ReadLine();

                    Console.Write("\nDigite o Saldo: ");
                    Saldo = float.Parse(Console.ReadLine());

                    Console.Write("\nA conta é Especial [ 1 = Sim | 0 = Não ]: ");
                    esp = int.Parse(Console.ReadLine());

                    if ((Nome != string.Empty))
                    {
                        if (esp == 1)
                        {
                            Especial = true;
                            Console.Write("Digite o limite a ser estabelecido: ");
                            Limite = float.Parse(Console.ReadLine());
                            if (Limite > 0)
                            {
                                //Atividade_Conta C = new Atividade_Conta(Nome, Saldo, Especial, Limite);
                                Console.WriteLine("! Conta criada com sucesso !");
                            }
                            else
                            {
                                //Atividade_Conta C = new Atividade_Conta(Nome, Saldo, Especial);
                                Console.WriteLine("! Conta criada com sucesso !");
                            }
                        }
                        else
                        {
                            //Atividade_Conta C = new Atividade_Conta(Nome, Saldo);
                            Console.WriteLine("! Conta criada com sucesso !");
                        }
                    }
                    else
                    {
                        //Atividade_Conta C = new Atividade_Conta(Nome, Saldo, Especial);
                    }
                } // end Conta;
                else if (A == 2)  // begin Operacoes;
                {
                    while (B != 0)
                    {
                        Console.WriteLine("SISTEMA DE ATENDIMENTO\n1 -  Saque\n2 - Deposito\n3 - Transferencia\n0 - Sair");
                        Console.Write("Selecione a opção: ");
                        B = int.Parse(Console.ReadLine());
                        if (B == 1) // Saque
                        {
                            Console.Write("Digite o valor do Saque: ");
                            Saque = float.Parse(Console.ReadLine());
                            C.Saque(Saque);
                            Console.WriteLine("! Operação Bem Sucedida !\nSaldo Atual: " + C.GetSaldo());
                        }
                        if (B == 2) // Deposito
                        {
                            Console.Write("Digite o valor do Deposito: ");
                            Deposito = float.Parse(Console.ReadLine());
                            C.Deposito(Deposito);
                            Console.WriteLine("! Operação Bem Sucedida !\nSaldo Atual: " + C.GetSaldo());
                        }
                        if (B == 3) // Transferencia
                        {
                            Console.Write("Digite o valor da Transferencia: ");
                            Transferencia = float.Parse(Console.ReadLine());
                            C.Transferencia(Transferencia);
                            Console.WriteLine("! Operação Bem Sucedida !\nSaldo Atual: " + C.GetSaldo());
                        }
                    }
                } // end Operacoes;
                else if ((A > 0) || (A > 2))
                {
                    Console.WriteLine("! Entrada Invalida !");
                    Console.ReadKey();
                }
            } // end Main;
            Console.ReadKey();
        }
    }
}
