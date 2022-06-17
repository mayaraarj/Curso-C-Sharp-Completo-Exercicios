using System;
using System.Globalization;


namespace Lojinha
{
    class Program
    //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o
    ///valor unitário de cada peça 1, o  código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
    // Calcule e mostre o valor a ser pago.

    {
        static void Main(string[] args)
        {
      
            double precoTotal;

            Console.WriteLine("Digite o código da primeira peça, a quantidade e o preço: ");
            string[] valores = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(valores[0]);
            int qtdPeca1 = int.Parse(valores[1]);
            double valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da segunda peça, a quantidade e o preço: ");
            valores = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(valores[0]);
            int qtdPeca2 = int.Parse(valores[1]);
            double valorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);


 
            precoTotal = (qtdPeca1 * valorPeca1) + (qtdPeca2 * valorPeca2);
            Console.WriteLine("O cliente deverá pagar: " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}