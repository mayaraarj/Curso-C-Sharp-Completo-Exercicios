namespace Lista_exercicios_estrutura_sequencial
{
    internal class ProgramSomaInteiros
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma  mensagem explicativa, conforme exemplos.

            int numero1;
            int numero2;
            int soma; 

            Console.WriteLine("Digite o primeiro número inteiro");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            numero2 = int.Parse(Console.ReadLine());
            soma = numero1 + numero2;
            Console.WriteLine($"A soma destes números é: {soma}");



        }
    }
}