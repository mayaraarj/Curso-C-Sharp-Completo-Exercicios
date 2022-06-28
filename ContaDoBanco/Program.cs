namespace ContaDoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            //bool deposito = 

            ContaBancaria conta1 = new ContaBancaria(numero, titular);
        }
    }
}