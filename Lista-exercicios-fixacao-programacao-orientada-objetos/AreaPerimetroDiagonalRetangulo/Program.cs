using System;
using System.Globalization;

namespace AreaPerimetroDiagonalRetangulo    
{
    internal class Program
    //Fazer um programa para ler os valores da largura e altura de um retângulo. Em
    //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();


            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRetangulo = retangulo.Area();
            double perimetroRetangulo = retangulo.Perimetro();
            double diagonalRetangulo = retangulo.Diagonal();

            Console.WriteLine("AREA = " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetroRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonalRetangulo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}