namespace ParImpar
{
    internal class Program
    //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numéro é par.");
            }
            else
            {
                Console.WriteLine("O número é impar.");
            }
        }
    }
}