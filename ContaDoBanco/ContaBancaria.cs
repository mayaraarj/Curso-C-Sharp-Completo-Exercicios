using System;

class ContaBancaria
{
    public int Numero
    { get; set; }
    string Titular
    { get; set; }

    double Saldo;


    public ContaBancaria(int numero, string titular, double saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
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

}
