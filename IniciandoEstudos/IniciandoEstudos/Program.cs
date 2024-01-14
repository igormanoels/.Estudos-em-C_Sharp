using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoEstudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Material inicial retirado do vídeo do youtube
             * Curso de C# - Aprenda o essencial em 5 HORAS
             * Canal: Vitor Lima - Ciência da Computação
             */

            //TODA AENTRADA NO C# É DADA COMO STRING
            int num = 24;
            double num2 = 2.4441;
            float num3 = 2.4441F;
            char letra = 's';
            string palavra = "Programação";
            bool verdade = true;
            // tipos primitivos
            var palavra2 = "programação";
            var num4 = 24;
            // outra forma de decarar uma variável
            dynamic numOUtexto = 3;
            numOUtexto = "Palavra";
            // variável dinamica, pode ter seu tipo alterado durante a execução
            //const int testeConstante = 25;
            // ao declarar uma variável como constante esse valor se torna imutável, seguindo o tipo definido
            /*
             * outra forma para seção de comentários
             */

            //Entrada, Processamento e Saída
            Console.Write("Informe seu Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo, " + nome);
            Console.Write(nome + ", qual é a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            //Estruturas de Decisão
            Console.WriteLine("\nVerifica se pode Votar e Dirigir!");
            if (idade >= 18)
            {
                Console.WriteLine("Parabéns " + nome + ", você pode Votar e Dirigir.");
            }
            else
            {
                if (idade >= 16)
                {
                    Console.WriteLine(nome + ", você só pode votar.");
                }
                else
                {
                    Console.WriteLine(nome + ", infelizmente você não pode votar e nem dirigir.");
                }
            }

            //Operadores Lógicos && (AND/E) --- || (OR/OU)
            Console.WriteLine("\nVerificando qual a sua faixa etária!");
            if (idade >= 1 && idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else
            {
                if (idade >= 13 && idade <= 17)
                {
                    Console.WriteLine("Você é um adolecente.");
                }
                else
                {
                    if (idade >= 18 && idade <= 64)
                    {
                        Console.WriteLine("Você é um adulto.");
                    }
                    else
                    {
                        Console.WriteLine("Você é um idoso.");
                    }
                }
            }

            //Método de Realizar Operações
            Console.WriteLine("\n\nOperações");
            Console.Write("Informe um número para saber o quadrado: ");
            double n1 = double.Parse(Console.ReadLine());
            double quadrado = n1 * n1;
            Console.Write("O quadrado é: " + quadrado);

            Console.ReadLine();
            //usando no cosole para interrupção
        }
    }
}
