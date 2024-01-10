// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            // recebe o valor em string e faz o cast para inteiro

            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            double res = valor1 * valor2;

            Console.WriteLine("Resultado: {0}", res);
        }
    }
}