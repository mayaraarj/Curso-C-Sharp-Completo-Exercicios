using System.Globalization;
using ExercicioFixacaoInterfaces.Service;
using ExercicioFixacaoInterfaces.Entities;

namespace ExercicioFixacaoInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int qtdInstallments = int.Parse(Console.ReadLine());

            Contract contract =  new Contract(contractNumber,contractDate,contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract,qtdInstallments);

            Console.WriteLine("Installments: ");
            foreach( Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }



        }
    }
}