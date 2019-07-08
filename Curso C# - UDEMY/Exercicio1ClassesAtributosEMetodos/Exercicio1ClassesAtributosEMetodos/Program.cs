using System;
using System.Globalization;

namespace Exercicio1ClassesAtributosEMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
