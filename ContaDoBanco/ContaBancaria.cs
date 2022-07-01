using System;
using System.Globalization;

class ContaBancaria
{
    public double Saldo { get; private set; }

    public int Numero { get; private set; }

    public string Titular { get; set; } // Alterei na correção retirando o private do set porque a pessoa poderá mudar o nome


    public ContaBancaria(int numero, string titular, double depositoInical) : this(numero, titular) // Testei o this na correção para reaproveitamento do reconstrutor anterior
    {
        //Numero = numero;
        //Titular = titular;
        //Saldo = depositoInical;

        Deposito(depositoInical); // Alterei a atriuição por chamada do método para facilitar manutenção posterior do código
    }

    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Saldo = 0;
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        Saldo = Saldo - quantia - 5.00;
    }

    public override string ToString()
    {
        return
            "Conta " +
            Numero +
            " " +
            ", Titular: " +
            Titular +
            ", Saldo: R$ " +
            Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

}
