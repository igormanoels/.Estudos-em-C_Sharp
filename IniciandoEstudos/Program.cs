using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoEstudos
{
    internal class Program
    {
        static string nome;
        static int opcao, idade;

        static void Main(string[] args)
        {
            Console.Write("Por favor, para iniciar informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine(nome + ", seja bem vindo a minha primeira aplicação com o C#.");

            MenuInicial();
        }

        static void MenuInicial()
        {
            Console.Write("\nEscolha uma das opções abaixo:" +
                "\n1- Tipos de Variáveis, Entrada e Saída de Dados." +
                "\n2- Operações Aritiméticas Simples." +
                "\n3- Estruturas de Decisão - Descubra see você pode votar." +
                "\n4- Estruturas de Decisão com Switch - Menu de Ações Bancárias." +
                "\n5- Estruturas de Repetição While, Do...While, Foreach e For." +
                "\n6- " +
                "\n7- " +
                "\n8- Encerrar o programa." +
                "\n\nDigite a opção desejada: ");
            
            do
            {
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 || opcao >= 9)
                {
                    Console.Write("Opção Inválida. Digite Novamente: ");
                } 
            }while (opcao <= 0 || opcao >= 9);
            
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    TrabalhandoComVariaveis();
                    break;
                case 2:
                    Console.Clear();
                    OperacoesMatematicas();
                    break;
                case 3:
                    Console.Clear();
                    VerificaVotarDirigir();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("\n" + nome + ", obrigado por testar minha aplicação, espero que tenha gostado.");
                    Console.WriteLine("\n\n\nAperte 'ENTER' para encerrar a aplicação...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        }

        static void TrabalhandoComVariaveis()
        {
            Console.WriteLine("Trabalhando com variáveis - Entrada , Processamento e Saída.");
            int num = 24;
            double num2 = 2.4441;
            float num3 = 2.4441F;
            char letra = 's';
            string palavra = "Programação";
            bool verdade = true;
                
            var palavra2 = "programação";
            var num4 = 24;  // outra forma de decarar uma variável, atribuir a variável como "VAR", o programa irá assumir qual seu tipo apartir da entrada
            
            dynamic numOUtexto = 3;
            numOUtexto = "Palavra"; // variável dinâmica, pode ter seu tipo alterado durante a execução

            const int testeConstante = 25;  // ao declarar uma variável como constante esse valor se torna imutável, seguindo o tipo definido
           
            //Entrada, Processamento e Saída
            Console.Write(nome + ", qual é a sua idade: ");  
            idade = int.Parse(Console.ReadLine());  //TODA AENTRADA NO C# É DADA COMO STRING
            Console.WriteLine("Entendido, então você tem " + idade + " anos.");

            Console.WriteLine("\n\n\nAperte 'ENTER' para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + ", estamos de volta ao menu, o que deseja fazer agora?");
            MenuInicial();
        }

        static void OperacoesMatematicas()
        {
            double num1, num2, res;
            
            Console.WriteLine("Operações Matemáticas.");
            Console.Write("Escolha uma das opções abaixo:" +
                "\n1- Adição." +
                "\n2- Subtração." +
                "\n3- Divisão." +
                "\n4- Multiplicação." +
                "\n5- Potência." +
                "\n6- Raiz Quadrada." +
                "\n\nDigite a opção desejada: ");

            do
            {
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 || opcao >= 7)
                {
                    Console.Write("Opção Inválida. Digite Novamente: ");
                }
            } while (opcao <= 0 || opcao >= 7);

            if (opcao <= 5)
            {
                Console.Write("Informe o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                    num2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        res = num1 + num2;
                        Console.WriteLine("Soma: " + res);
                        break;
                    case 2:
                        res = num1 - num2;
                        Console.WriteLine("Subtração: " + res); 
                        break;
                    case 3:
                        res = num1 / num2;
                        Console.WriteLine("Divisão: " + res);
                        break;
                    case 4:
                        res = num1 * num2;
                        Console.WriteLine("Multiplicação: " + res);
                        break;
                    case 5:
                        res = (Math.Pow(num1, num2));
                        Console.WriteLine("Potência: " + res);
                        break;
                }             
            }
            else
            {
                Console.Write("Informe o número desejado: ");
                num1 = int.Parse(Console.ReadLine());
                res = (Math.Sqrt(num1));
                Console.WriteLine("Raiz Quadrada: " + res);
            }

            Console.WriteLine("\n\n\nAperte 'ENTER' para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + ", estamos de volta ao menu, o que deseja fazer agora?");
            MenuInicial();
        }

        static void VerificaVotarDirigir()
        {
            Console.WriteLine("Verifica se pode Votar e Dirigir.");
            Console.WriteLine(nome + ", agora a partir da sua idade vamos verificar o que você já pode fazer.");

            if (idade == 0)
            {
                Console.Write("Por favor informe sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            else if (idade != 0)
            {
                Console.Write("\n" + idade + " anos é a idade cadastrada, está correto? ");
                Console.Write("\nPor favor digite Y / N: ");
                string letra = Console.ReadLine();

                if (letra.Equals("N") || letra.Equals("n"))
                {
                    Console.Write("Por favor informe sua idade correta: ");
                    idade = int.Parse(Console.ReadLine());
                }
            }

            if (idade >= 18)
            {
                Console.WriteLine("\nParabéns " + nome + ", você pode Votar e Dirigir.");
            }
            else
            {
                if (idade >= 16)
                {
                    Console.WriteLine("\n" + nome + ", você só pode votar.");
                }
                else
                {
                    Console.WriteLine("\n" + nome + ", infelizmente você não pode votar e nem dirigir.");
                }
            }



            Console.WriteLine("\n\n\nAperte 'ENTER' para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + ", estamos de volta ao menu, o que deseja fazer agora?");
            MenuInicial();
        }

    }
}
