using System;
using System.Globalization;

namespace ExemploMembrosEstaticosAula47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Calculadora.Circuferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Hello World!");
        }
    }
}
