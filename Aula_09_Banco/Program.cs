using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Banco
{
    class Program //Exeções - Criação & Implementação
                  //Deve ser adicionado cada excecao que ocorrera em catch
                  //independentes
    {
        static void Main(string[] args)
        {
            //ContaPoupanca contaPoupanca = new ContaPoupanca(); // o que conta tem "poupanca tambem terá
            // Conta conta = new ContaPoupanca é possivel
            //Conta conta = new Conta();
            ContaPoupanca conta = new ContaPoupanca(0.10); // o que conta tem "poupanca tambem terá
            conta.Numero = 1;
            conta.Saldo = 500;

            //contaPoupanca.Saldo = 100;

            Console.WriteLine("O Saldo da conta é: " + conta.Saldo);
            try
            { // A sobrecarga de metodo ocorre quando utilizamos mesmo metodo, mas parametros diferentes
                conta.Saca(100);
                Console.WriteLine(conta.Mensagem);
                Console.WriteLine("O saldo da conta é: " + conta.Saldo);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Saldo Insuficiente!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Não foi possivel sacar valor negativo. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
