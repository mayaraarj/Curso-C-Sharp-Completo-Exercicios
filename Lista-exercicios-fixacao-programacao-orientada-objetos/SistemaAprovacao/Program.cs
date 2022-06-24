using System;
using System.Globalization;

namespace SistemaAprovacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno student = new Aluno();

            Console.Write("Nome do Aluno: ");
            student.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            student.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + student.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Aprovacao())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + student.FaltamPontos().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}