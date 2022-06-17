namespace LendoCoordenadas
{
    internal class Program
    //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
    //cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo
    //menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas");

            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante - Q1");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto Quadrante - Q4");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante - Q3");
                }
                else
                {
                    Console.WriteLine("Segundo Quadrante - Q2");
                }

                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }

        }
    }
}