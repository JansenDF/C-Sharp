using System;
class Cliente
{
    public string Nome;
    public double Saldo;

    public double Depositar(double deposito)
    {
        double novoSaldo = this.Saldo + deposito;
        return novoSaldo;
    }
    public double Sacar(double saque)
    {
        double novoSaldo = this.Saldo - saque;
        return novoSaldo;
    }
}