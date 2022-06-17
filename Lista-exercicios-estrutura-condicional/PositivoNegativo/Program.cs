namespace PositivoNegativo
{
    internal class Program
    {
        //Proposta original: Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        // Incrementei a possibilidade de o número ser 0, considerado nem positivo nem negativo.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo!");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O número é zero!");
            }
            else
            {
                Console.WriteLine("O número é negativo!");
            }
        }
    }
}