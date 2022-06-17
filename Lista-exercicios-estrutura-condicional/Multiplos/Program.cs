namespace Multiplos
{
    internal class Program
    {
        //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        //ordem crescente ou decrescente.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de um número inteiro:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de outro número inteiro:");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
        }
    }
}