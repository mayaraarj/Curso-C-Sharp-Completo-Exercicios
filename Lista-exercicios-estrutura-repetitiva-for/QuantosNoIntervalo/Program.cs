namespace QuantosNoIntervalo
{
    internal class Program
    //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
    //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           for (int i =1; i <= n; i++)
            {
                if (n >=10 && n <= 20)
                {
                    Console.WriteLine("in " + n);
                }
                else
                {
                    Console.WriteLine("out " +n);
                }
            }



        }
    }
}