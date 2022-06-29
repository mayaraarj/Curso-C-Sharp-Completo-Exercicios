using System;
using System.Globalization;

class ContaBancaria
{
    public double Saldo { get; private set; }

    public int Numero { get; private set; }

    public string Titular { get; private set; }


    public ContaBancaria(int numero, string titular, double depositoInical)
    {
        Numero = numero;
        Titular = titular;
        Saldo = depositoInical;
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
            " "+
            ", Titular: "+
            Titular +
            ", Saldo R$ " +
            Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

}
