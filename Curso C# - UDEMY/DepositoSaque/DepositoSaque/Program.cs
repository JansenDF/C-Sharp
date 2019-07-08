using System;
using System.Globalization;

class Conta
{
    static void Main()
    {
        Cliente c1 = new Cliente();
        c1.Nome = "Jansen";
        c1.Saldo = 100;
        double novoSaldo = c1.Depositar(50);
        Console.WriteLine($"Novo saldo é; {novoSaldo.ToString("F2", CultureInfo.InvariantCulture)} ");
        novoSaldo = c1.Sacar(10);
        Console.WriteLine($"Novo saldo é: {novoSaldo.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}