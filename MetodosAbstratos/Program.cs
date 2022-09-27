using MetodosAbstratos.Entities;
using System.Globalization;

namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (payerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (payerType == 'c')
                {
                    Console.WriteLine("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,anualIncome, numberEmployees));
                }

            }
            Console.WriteLine();
            double sum = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " +taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxPayer.Tax();
            }
            Console.WriteLine(" ");
            Console.WriteLine("TOTAL TAXES: $ "+ sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}