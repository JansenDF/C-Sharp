using System;
using System.Globalization;

namespace ExercicioFixacaoAula60
{
    class Conta
    {
        private double _saldo;
        private double _taxa = 5.00;
        public double NumeroConta { get; private set; }
        public string Titular { get; set; }
        public Conta(double numConta, string titular, double saldo)
        {
            NumeroConta = numConta;
            Titular = titular;
            _saldo = saldo;
        }
        public void Depositar(double deposito) {
            _saldo += deposito;
        }
        public void Sacar(double saque)
        {
            _saldo -= saque + _taxa;
        }
        public override string ToString()
        {
            return $"{NumeroConta}, Titular: {Titular}, Saldo: ${_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}