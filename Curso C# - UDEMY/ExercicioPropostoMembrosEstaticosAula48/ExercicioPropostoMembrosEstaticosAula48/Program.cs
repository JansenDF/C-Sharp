using System;
using System.Globalization;

namespace ExercicioPropostoMembrosEstaticosAula48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalPagar = ConversorDeMoedas.Conversor(cotacaoDolar, qtdDolares);

            Console.Write($"Valor a ser pago em reais = {totalPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
