using System;
using System.Globalization;


namespace LendoCirculos
{
    internal class Program
    //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. 
    //Fórmula da área: area = π.raio2
    //Considere o valor de π = 3.14159

    {
        static void Main(string[] args)
        {
            double raio, area,pi = 3.14159;
            
            Console.WriteLine("Digite o valor do raio do círculo: ");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = pi * Math.Pow (raio,2);
            Console.WriteLine("A área do círculo é de: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}