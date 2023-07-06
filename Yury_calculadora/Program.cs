using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora"; 
            Console.WriteLine("--------------------Calculadora--------------------"); 

            double valor1 = 0, valor2 = 0, resultado, numero; 
            string operador, valorDigitado;
            bool numero_inteiro;

            

            Console.WriteLine("Digite o primeiro valor: ");
            valorDigitado = Console.ReadLine();

            
            numero_inteiro = double.TryParse(valorDigitado, out numero);

             
            if (numero_inteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 3);
                
            }
            else
            {
                Console.WriteLine("Digite um número válido.");
            }

            Console.WriteLine("Digite a operação matemática desejada: ( /= divisão , * = multiplicação, + = soma, - = subtração e % = MOD resto ): ");
            operador = Console.ReadLine();

            
            Console.WriteLine("Digite o segundo valor: ");
            valorDigitado = Console.ReadLine();
            numero_inteiro = double.TryParse(valorDigitado, out numero);
            if (numero_inteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 3);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }

            

            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 3);
                    Console.WriteLine($"{valor1} {'+'} {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 3);
                    Console.WriteLine($"{valor1} {'-'} {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 3);
                    Console.WriteLine($"{valor1} {'*'} {valor2} = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 3);
                    Console.WriteLine($"{valor1} {'/'} {valor2} = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 3);
                    Console.WriteLine($"{valor1} {'%'} {valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }

            Console.ReadKey();
        }
    }
}