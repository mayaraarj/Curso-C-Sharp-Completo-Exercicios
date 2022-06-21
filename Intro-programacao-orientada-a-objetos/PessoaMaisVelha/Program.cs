using System;

namespace PessoaMaisVelha
{
    internal class Program
    //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais  velha. 

    {
        static void Main(string[] args)
        {

            Pessoa primeiraPessoa, segundaPessoa;
            primeiraPessoa = new Pessoa();
            segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());



            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.Nome}");
            } else if(primeiraPessoa.Idade < segundaPessoa.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {segundaPessoa.Nome}");
            } else
            {
                Console.WriteLine("As pessoas tem a mesma idade");
            }




        }
    }
}