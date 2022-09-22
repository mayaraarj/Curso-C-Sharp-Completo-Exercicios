using System.Globalization;
using HerancaEPolimorfismo.Entities;

namespace HerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c')
                {
                    products.Add(new Product(productName, productPrice));

                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                }
                else if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(productName, productPrice, customsFee));

                }
                else
                {
                    Console.WriteLine("Invalid product type!");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }



        }
    }
}