using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR
{
    class Tarefa_02
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            Console.WriteLine("*** Indice de Massa Corporal ***");
            Console.Write("Digite o seu peso: "); peso = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a sua altura: "); altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            Console.WriteLine("O seu IMC é: " + imc.ToString("F"));
            Console.WriteLine("O Tipo de dados Utilizado é: " + peso.GetType());
            if (imc < 18.5d) Console.WriteLine("Você está abaixo do peso !");
            else if ((imc > 18.6d) && (imc < 24.9d)) Console.WriteLine("Parabéns você está no peso ideal !");
            else if ((imc > 25.0d) && (imc < 29.9d)) Console.WriteLine("Você está levemente acima do peso !");
            else if ((imc > 30.0d) && (imc < 34.9d)) Console.WriteLine("Você está diagnosticado com Obesidade grau I !");
            else if ((imc > 35.0d) && (imc < 39.9d)) Console.WriteLine("Você está diagnosticado com Obesidade grau II (Severa) !");
            else if (imc > 40.0d) Console.WriteLine("Você está diagnosticado com Obesidade grau III (Mórbida) !");

            Console.ReadKey();
        }
    }
}