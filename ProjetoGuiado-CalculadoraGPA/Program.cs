using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuiado_CalculadoraGPA
{
    internal class Program
    {
        static void Main()
        {
            // Primeiro Projeto Microsoft Learn - Cálculadora GPA Trazendo para o constexto brasileiro
            string aluno;
            decimal [] n1 = new decimal[5];
            decimal mediaF = 0;
            int sem = 1;

            Console.WriteLine("Seja Bem Vindo! Vamos cálcular a média?");
            Console.Write("\nFavor informar o nome do aluno: ");
            aluno = Console.ReadLine();
            
            for ( int i = 0; i <= 4; i++ )
            {
                Console.Write($"Informe a nota do {sem}º bimestre ");
                n1[i] = decimal.Parse(Console.ReadLine());
                mediaF += n1[i];
                sem += 1;
            }

            sem = 1;
            Console.Write($"\n\nAluno(a): {aluno}\n\nPeríodo\t\tNota\n");
            
            for ( int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{sem}º bimestre\t\t{n1[i]}");
                sem ++;
            }

            Console.Write($"\nMédia Final:{Math.Round((mediaF / 5),2)}");

            Console.Write("\n\n\nPressione \"Enter\" para encerrar");
            Console.Read();
        }
    }
}
