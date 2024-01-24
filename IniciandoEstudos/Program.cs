using Microsoft.SqlServer.Server;
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
                "\n3- Estruturas de Decisão - Descubra se você pode votar." +
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
                    Console.Clear();
                    AplicacaoBancaria();
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
            decimal dinheiros; //variável utilizada para valores financeiros


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
        
        static void AplicacaoBancaria()
        {
            double valor, taxa, tempo, juros, montante, parcela, amortizacao, saldoDev; //variável utilizada para valores financeiros
            string moeda = " "; // precisei atribuir um valor para corrigir o erro

            Console.WriteLine("Aplicação Bancária.");
            Console.WriteLine(nome + ", aqui você terá acesso a ações similares a do seu Banco.");
            Console.Write("Escolha uma das opções abaixo:" +
                "\n1- Cálcular juros simples." +
                "\n2- Cálcular juros compostos." +
                "\n3- Sistema de Amortização Constante (SAC)." +
                "\n4- Sistema Price de Armotização (Tabela Price)." +
                "\n5- Conversor de Moeda." +
                "\n\nDigite a opção desejada: ");
            
            do
            {
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 && opcao >= 6)
                {
                    Console.Write("Opção Inválida. Digite Novamente: ");
                }
            } while (opcao <= 0 && opcao >= 6);
        
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nCerto, então vamos cálcular o Juros Simples.");

                    Console.Write("Favor informar o valor: ");
                    valor = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar a taxa: ");
                    taxa = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar o tempo em mesês: ");
                    tempo = double.Parse(Console.ReadLine());

                    if (taxa >= 1)
                    {
                        taxa = (taxa / 100);
                    }

                    juros = (valor * taxa * tempo);
                    montante = juros + valor;
                    Console.WriteLine("\nJuros Simples: " + juros.ToString("C2")); // ToString() converte em string. E "C2": especifica o número de casas decimais.
                    Console.WriteLine("Montante: " + montante.ToString("C2"));
                    break;
                case 2:
                    Console.WriteLine("\nCerto, então vamos cálcular o Juros Compostos.");

                    Console.Write("Favor informar o valor: ");
                    valor = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar a taxa: ");
                    taxa = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar o tempo em mesês: ");
                    tempo = double.Parse(Console.ReadLine());

                    if (taxa >= 1)
                    {
                        taxa = (taxa / 100);
                    }

                    montante = (valor * Math.Pow((1 + taxa), tempo));
                    juros = montante - valor;
                    Console.WriteLine("\nJuros Simples: " + juros.ToString("C2")); // ToString() converte em string. E "C2": especifica o número de casas decimais.
                    Console.WriteLine("Montante: " + montante.ToString("C2"));
                    break;
                case 3:
                    Console.WriteLine("\nCerto, então vamos cálcular o valor da parcelas segundo a tabela SAC.");
                    
                    Console.Write("Favor informar o valor do Empréstimo/ Financiamento: ");
                    montante = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar o tempo em mesês: ");
                    tempo = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar a taxa: ");
                    taxa = double.Parse(Console.ReadLine());

                    if (taxa >= 1)
                    {
                        taxa = (taxa / 100);
                    }

                    Console.WriteLine("\n|  Parcela   |  Amortização  |  Juros   |  Saldo Devedor   |  Pagamento  |");
                    amortizacao = montante / tempo;

                    for ( int i = 1; i <= tempo; i++)
                    {   
                        juros = montante * taxa;
                        montante = montante - amortizacao;
                        parcela = amortizacao + juros;

                        Console.WriteLine($"|  {i}   |  {amortizacao.ToString("C2")}  |  {juros.ToString("C2")}  |  {montante.ToString("C2")}   |  {parcela.ToString("C2")}   |");
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("\nCerto, então vamos cálcular o valor da parcelas segundo a tabela Price.");

                    Console.Write("Favor informar o valor do Empréstimo/ Financiamento: ");
                    montante = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar o tempo em mesês: ");
                    tempo = double.Parse(Console.ReadLine());
                    Console.Write("Favor informar a taxa: ");
                    taxa = double.Parse(Console.ReadLine());

                    if (taxa >= 1)
                    {
                        taxa = (taxa / 100);
                    }

                    valor = ((montante * taxa) / ((1 - (Math.Pow((1 + taxa), -tempo)))));
                    montante = valor * tempo;

                    //amortizacao = (valor - ((montante * taxa) / (1-(Math.Pow((1+taxa),-tempo)))));
                    Console.WriteLine("\nAs parcelas serão de: " + valor.ToString("C2"));
                    Console.WriteLine("O total do financiamento será de: " + montante.ToString("C2"));

                    break;
                case 5:
                    Console.WriteLine("\nCerto, então vamos ao Conversor de Moedas.");
                    Console.WriteLine("1-USD  |  2-EUR  |  3-GBP  |  4-CNY   |  5-ARS  |  6-BTC  |  7-ETH  |");
                    Console.Write("Digite a opção desejada: ");
                    
                    opcao = int.Parse(Console.ReadLine());
                    
                    Console.Write("Informe quanto deseja converter: R$ ");
                    valor = double.Parse(Console.ReadLine());

                    switch(opcao)
                    {
                        case 1:
                            valor = valor * 0.2;
                            moeda = "USD";
                            Console.WriteLine("\nConvertendo Reais em Dólar.");
                            break;
                        case 2:
                            valor = valor * 0.19;
                            moeda = "EUR";
                            Console.WriteLine("\nConvertendo Reais em Euro.");
                            break;
                        case 3:
                            valor = valor * 0.16;
                            moeda = "GBP";
                            Console.WriteLine("\nConvertendo Reais em Libra.");
                            break;
                        case 4:
                            valor = valor * 1.45;
                            moeda = "CNY";
                            Console.WriteLine("\nConvertendo Reais em Yuan Chinês.");
                            break;
                        case 5:
                            valor = valor * 165.89;
                            moeda = "ARS";
                            Console.WriteLine("\nConvertendo Reais em Pesos Argentinos.");
                            break;
                        case 6:
                            valor = valor * 0.0000051;
                            moeda = "BTC";
                            Console.WriteLine("\nConvertendo Reais em BTC.");
                            break;
                        case 7:
                            valor = valor * 0.0091;
                            moeda = "ETH";
                            Console.WriteLine("\nConvertendo Reais em Ethereum.");
                            break;
                        default:
                            Console.WriteLine("\nOpção Inválida");
                            break;
                    }

                    Console.Write($"O valor convertido é de: {moeda} {Math.Round(valor, 2):F2}");

                    break;
            }

            Console.WriteLine("\n\n\nAperte 'ENTER' para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + ", estamos de volta ao menu, o que deseja fazer agora?");
            MenuInicial();
        }


    }
}
