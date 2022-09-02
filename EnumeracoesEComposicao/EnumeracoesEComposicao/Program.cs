using EnumeracoesEComposicao.Entitties;
using EnumeracoesEComposicao.Entitties.Enum;

namespace EnumeracoesEComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Bith date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order?");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(name, price);
                Console.Write("Quantity: ");
                qtd = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(qtd, price, product);

            }

            Order order = new Order(DateTime.Now, status,client);

            //Console.WriteLine("ORDER SUMMARY: ");

         







        }
    }
}