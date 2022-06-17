namespace CalculadorSalarios
{
    using System;
    using System.Globalization;
    
    internal class Program

    //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por  hora
    //e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas  decimais.

    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            int horasTrabalhadas;
            double valorHora, salario;

            Console.WriteLine("Digite o nome do funcionário: ");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Quantas horas este funcionário trabalhou?");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da hora deste funcionário?");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;
            Console.WriteLine("O salário deste funcionário será de " + salario.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

        }
    }
}