using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
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

            int num = 24;
            double num2 = 2.4441;
            float num3 = 2.4441F;
            char letra = 's';
            string palavra = "Programação";
            bool verdade = true;
            var palavra2 = "programação";
            var num4 = 24;

            // seção de comentários

            /*
             * outra forma para seção de comentários
             */

            Console.Write("Informe um número: ");
            //escrever no console

            var valor = Console.ReadLine();
            //ao atribuir num como var ou String, ele receberá a entrada em forma de texto.

            valor = valor + num;
            // por var receber valores como String ele uni o número como se fosse um caracter
            
            Console.WriteLine("Você digitou " + valor);
            // o operador + serve para concatenar as informações para printar na tela
        }
    }
}
