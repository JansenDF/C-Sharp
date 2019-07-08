using System;
using System.Globalization;

namespace ExercicioFixacaoAula60
{
    class Program
    {
        static public void Main(String[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            double saldo = 0.0;
            Console.Write("Haverá depósito inicial? (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            Conta c = new Conta(numConta, titular, saldo);
            double deposito;
            if (resp == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Depositar(deposito);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c}");
            Console.Write("Entre o valor de depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {c}");
            Console.Write("Entre o valor de saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {c}");

        }
    }
}