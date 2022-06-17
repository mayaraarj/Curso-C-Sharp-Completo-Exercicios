using System;
using System.Globalization;


namespace QuatroValores
{
    internal class Program
    //Fazer um programa para ler quatro valores inteiros A, B, C e D.
    //A seguir, calcule e mostre a diferença do produto  de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            double diferenca;

            Console.WriteLine("Digite o valor do número inteiro A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número inteiro B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número inteiro C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do número inteiro D: ");
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B - C * D);

            Console.WriteLine(diferenca.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}