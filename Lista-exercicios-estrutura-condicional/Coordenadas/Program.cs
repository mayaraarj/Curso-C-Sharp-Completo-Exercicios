using System;
using System.Globalization;

namespace Coordenadas
{
    //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
    //de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o
    //ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    //Se o ponto estiver na origem, escreva a mensagem “Origem”.
    //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
    //situação.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas do ponto(x,y). Estes valores deverão ter uma casa decimal");
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("O ponto está na origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("O ponto está no eixo y");
            }
            else if (y == 0)
            {
                Console.WriteLine("O ponto está no eixo x");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("O ponto está no Quadrante 1 - Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("O ponto está no Quadrante 4 - Q4");
            }
            else if (x <0 && y < 0)
            {
                Console.WriteLine("O ponto está no Quadrante 3 - Q3");
            }
            else
            {
                Console.WriteLine("O ponto está no Quadrante 2 - Q2");
            }
        }
    }
}