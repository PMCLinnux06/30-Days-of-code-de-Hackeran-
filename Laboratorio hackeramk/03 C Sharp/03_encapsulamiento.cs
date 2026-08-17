using System;

class Cuenta
{
    private double saldo;

    public Cuenta(double saldo)
    {
        this.saldo = saldo;
    }

    public void Depositar(double cantidad)
    {
        saldo += cantidad;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("Saldo: " + saldo);
    }

    static void Main()
    {
        Cuenta cuenta = new Cuenta(100);
        cuenta.Depositar(50);
        cuenta.MostrarSaldo();
    }
}
