using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program : Banco
    {
        static void NotMain(string[] args)
        {
            Banco B = new Banco();
            Conta C = new Conta();
            Contrato c = new Contrato();

            string numeroConta = string.Empty;
            decimal valor = 0;
            int A = 1, SG = 1, SC = 1;

            while (A != 0)
            {
                Console.WriteLine("\nBem Vindo ao banco " + B.Nome);
                Console.Write("\n1 - Sistema de Gerenciamento\n2 - Sistema de Consulta\n0 - Sair\nSelecione o sistema: ");
                A = int.Parse(Console.ReadLine());
                switch (A)
                {
                    case 0:/*Sair*/
                        break;
                    case 1: /*Sistema de Gerenciamento*/
                        while (SG != 0)
                        {
                            Console.WriteLine("\n\nSistema de Gerenciamento");
                            Console.Write("\n1 - Cadastrar Conta\n2 - Cadastrar Contrato\n3 - Encerrar Conta\n4 - Encerrar Contrato\n0 - Voltar para o Sistema Principal\nSelecione a operação: ");
                            SG = int.Parse(Console.ReadLine());
                            switch (SG)
                            {
                                case 0:/*Sair*/
                                    break;

                                case 1:/*Cadastro_Conta*/
                                    Console.Write("\nDigite o nome do Titular: ");
                                    C.NomeCliente = Console.ReadLine();
                                    Console.Write("\nDigite o número da conta: ");
                                    C.NumeroConta = Console.ReadLine();
                                    Console.Write("\nDigite o saldo da conta: ");
                                    C.Saldo = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nA conta é especial ? : ");
                                    C.Especial = decimal.Parse(Console.ReadLine());

                                    CadastrarConta(C);
                                    Console.WriteLine("\n! Conta Cadastrada com sucesso !");
                                    break;

                                case 2:/*Cadastro_Contrato*/
                                    Console.Write("\nDigite o numero do contrato: ");
                                    c.NUmeroContrato = Console.ReadLine();
                                    Console.Write("\nDigite o valor total: ");
                                    c.ValorTotalContrato = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nDigite o valor da parcela: ");
                                    c.ValorParcela = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nDigite o numero de parcelas : ");
                                    c.NumeroParcelas = int.Parse(Console.ReadLine());

                                    CadastrarContrato(c);
                                    Console.WriteLine("\n! Contrato Cadastrado com sucesso !");
                                    break;

                                case 3:/*Encerrar_Conta*/
                                    Console.Write("\nDigite o numero da conta: ");
                                    ExcluirConta(Console.ReadLine());
                                    break;

                                case 4:/*Encerrar_Contrato*/
                                    Console.Write("\nDigite o numero do contrato: ");
                                    ExcluirContrato(Console.ReadLine());
                                    break;

                                default:
                                    Console.WriteLine("! Seleção Invalida !");
                                    break;
                            }
                            break;
                        }
                        break;
                    case 2: /*Sistema de Consulta*/
                        while (SC != 0)
                        {
                            Console.WriteLine("\n\nSistema de Consulta");
                            Console.Write("\n1 - Deposito\n2 - Saque\n3 - Saldo\n0 - Voltar para o Sistema Principal\nSelecione a operação: ");
                            SC = int.Parse(Console.ReadLine());
                            switch (SC)
                            {
                                case 0:/*Sair*/
                                    break;

                                case 1:/*Deposito*/
                                    Console.Write("\nDigite o numero da conta: ");
                                    numeroConta = Console.ReadLine();
                                    Console.Write("\nDigite o valor: ");
                                    valor = decimal.Parse(Console.ReadLine());

                                    Depositar(numeroConta, valor);
                                    break;
                                case 2:/*Saque*/
                                    Console.Write("\nDigite o numero da conta: ");
                                    numeroConta = Console.ReadLine();
                                    Console.Write("\nDigite o valor: ");
                                    valor = decimal.Parse(Console.ReadLine());

                                    Sacar(numeroConta, valor);
                                    break;

                                case 3:/*Saldo*/
                                    Console.Write("\nDigite o numero da conta: ");
                                    numeroConta = Console.ReadLine();

                                    ImprimirSaldo(numeroConta);
                                    //SaldoAlternado(numeroConta);
                                    break;

                                default:
                                    Console.WriteLine("! Seleção Invalida !");
                                    break;
                            }
                            break;
                        }
                        break;

                    default:
                        Console.WriteLine("! Seleção Invalida !");
                        break;
                }
            }

            Console.ReadKey();
        }
        static void CadastrarConta(Conta C)
        {
            conta.Add(C);
            Dconta.Add(int.Parse(C.NumeroConta), conta);
        }
        static void CadastrarContrato(Contrato c)
        {
            contrato.Add(c);
        }
        static void ExcluirConta(string numeroConta)
        {
            int n = 0;
            for (int i = 0; i < conta.Count; i++)
            {
                if (conta[i].NumeroConta == numeroConta)
                {
                    conta.RemoveAt(i); n++; break;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("! Conta eliminada con sucesso !");
            }
            else
            {
                Console.WriteLine("! Não foi possivel eliminar esta conta !");
            }
        }
        static void ExcluirContrato(string numeroContrato)
        {
            int n = 0;
            for (int i = 0; i < contrato.Count; i++)
            {
                if (contrato[i].NUmeroContrato == numeroContrato)
                {
                    contrato.RemoveAt(i); n++; break;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("! Contrato eliminado con sucesso !");
            }
            else
            {
                Console.WriteLine("! Não foi possivel eliminar este contrato !");
            }
        }
        static void Depositar(string numeroConta, decimal valor)
        {
            int n = 0;
            for (int i = 0; i < conta.Count; i++)
            {
                if (conta[i].NumeroConta == numeroConta)
                {
                    conta[i].Saldo += valor; n++; break;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("! Deposito realizado con sucesso !");
            }
            else
            {
                Console.WriteLine("! Não foi possivel realizar o deposito !");
            }
        }
        static void Sacar(string numeroConta, decimal valor)
        {
            int n = 0;
            for (int i = 0; i < conta.Count; i++)
            {
                if (conta[i].NumeroConta == numeroConta)
                {
                    conta[i].Saldo -= valor; n++; break;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("! Saque realizado con sucesso !");
            }
            else
            {
                Console.WriteLine("! Não foi possivel realizar o saque !");
            }
        }
        static void ImprimirSaldo(string numeroConta)
        {
            var numQuery =
            from num in conta
            where num.NumeroConta == numeroConta
            select num.Saldo;
            if (numQuery.FirstOrDefault() != 0)
            {
                Console.WriteLine("O seu saldo é: " + numQuery.FirstOrDefault());
            }
            else
            {
                Console.WriteLine("! Não foi possivel verificar o seu saldo !");
            }
        }
        static void SaldoAlternado(string numeroConta)
        {
            var numQuery =
            from num in Dconta
            where num.Key == int.Parse(numeroConta)
            select num.Key;
            if (numQuery.FirstOrDefault() != 0)
            {
                Console.WriteLine("O seu saldo é: " + Dconta[Dconta.Keys.ElementAt(int.Parse(numeroConta))]);
            }
            else
            {
                Console.WriteLine("! Não foi possivel verificar o seu saldo !");
            }
        }
    }
}

