using System;
using System.Globalization;


namespace LocalizandoIntervalos
{
    internal class Program
    //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
    //seguintes intervalos([0,25], (25,50], (50,75], (75,100]) este valor se encontra.Obviamente se o valor não estiver em
    //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor qualquer");
            double valorDigitado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorDigitado < 0 || valorDigitado > 100.00)
            {
                Console.WriteLine("Valor fora de intervalo");
            }
            else if (valorDigitado <= 25.00) 
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if ( valorDigitado <= 50.00)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valorDigitado <= 75.00)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if  (valorDigitado <= 100.00)
            {
                Console.WriteLine("Intervalo [50,100]");
            }

        }
    }
}