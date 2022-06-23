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
            student.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 




        }
    }
}