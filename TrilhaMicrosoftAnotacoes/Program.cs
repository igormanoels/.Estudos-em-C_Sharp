using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrilhaMicrosoftAnotacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ANOTAÇÕES DO CURSO DE C# DA MICROSOFT
            string nome, sobrenome, msg;

            nome = "Igor";
            msg = $"Seja Bem Vindo {nome}!";
            Console.WriteLine(msg);

            sobrenome = "Manoel";
            msg = $"{nome} {sobrenome}!";
            Console.WriteLine("Seja Bem Vindo " + msg);

            Console.WriteLine(@"        
            c:\source\repos    
            (Como incluir um repositório e um texto de aviso)"); // Com o uso do @ o texto ao ser exibido replica os espaços utilizado e quebras de linha sem o uso do \n

            int valor = 1;
            valor++;
            Console.WriteLine("Primeiro: " + valor);            // Exibe o valor 
            Console.WriteLine($"Segundo: {valor++}");           // Recupera e exibe o valor, depois incrementa   
            Console.WriteLine("Terceiro: " + valor);            // Exibe o valor o valor do incremento
            Console.WriteLine("Quarto: " + (++valor));          // Incrementa e exibe o valor

            decimal temp = 94m;
            decimal res = (temp - 32) * 5 / 9;
            Console.WriteLine("The temperature is " + Math.Round(res,2) + " Celsius.");



            Console.Write("\n\nPressione \"Enter\" para encerrar"); // O Uso da   \"...\" permite que o texto inclua aspas duplas na saída  
            Console.Read();
        }
    }
}
