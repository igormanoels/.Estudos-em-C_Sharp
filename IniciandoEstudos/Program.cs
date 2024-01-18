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
        static int opcao;

        static void Main(string[] args)
        {
            Console.Write("Por favor, para iniciar informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine(nome + ", seja bem vindo a minha primeira aplicação com o C#.");

            MenuInicial();

            Console.ReadLine();
        }

        static void MenuInicial()
        {
            Console.Write("\nEscolha uma das opções abaixo:" +
                "\n1- Tipos de Variáveis, Entrada e Saída de Dados." +
                "\n2- Operações Aritiméticas Simples." +
                "\n3- Estruturas de Decisão - Descubra see você pode votar" +
                "\n4- Estruturas de Decisão com Switch - Menu de Ações Bancárias" +
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
            //*/
        }
    }
}
