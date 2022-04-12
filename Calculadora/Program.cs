using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program : Operacoes
    {
        static void Main(string[] args)
        {
            int A = 1;
            float a = 0, b = 0;
            double c = 0, d = 0;
            Operacoes O = new Operacoes();
            while (A != 0)
            {
                Console.WriteLine("! SISTEMA DE CALCULADORA !");
                Console.Write("\n1 - Soma\n2 - Resta\n3 - Multiplicação\n4 - Divisão\n5 - Paridade\n6  - Potenciação\n7 - Radiciação\n0 - Sair\nOperação Selecionada: ");
                try
                {
                    A = int.Parse(Console.ReadLine());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (A)
                {
                    case 1:
                        Console.Write("\nDigite o primeiro número: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo número: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Soma(a, b));
                        break;
                    case 2:
                        Console.Write("\nDigite o primeiro número: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo número: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Resta(a, b));
                        break;
                    case 3:
                        Console.Write("\nDigite o primeiro número: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo número: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Mult(a, b));
                        break;
                    case 4:
                        Console.Write("\nDigite o primeiro número: ");
                        a = float.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo número: ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Div(a, b));
                        break;
                    case 5:
                        Console.Write("\nDigite o número: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("O número é: " + O.DefParidade(a));
                        break;
                    case 6:
                        Console.Write("\nDigite o primeiro número: ");
                        c = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo número: ");
                        d = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Pot(c, d));
                        break;
                    case 7:
                        Console.Write("\nDigite o primeiro número: ");
                        c = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado será: " + O.Rad(c));
                        break;
                    default: Console.WriteLine("! Seleção Incorreta !"); break;
                }
            }
        }
    }
}
