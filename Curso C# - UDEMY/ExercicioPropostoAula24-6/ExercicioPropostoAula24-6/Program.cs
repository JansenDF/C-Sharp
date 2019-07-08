using System;
using System.Globalization;

namespace ExercicioPropostoAula24_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = trian(a, c);
            double circulo = circ(c);
            double trapezio = trap(a, b, c);
            double quadrado = quad(b);
            double retangulo = ret(a, b);

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }

        static double trian(double n1, double n2)
        {
            double t = (n1 * n2)/2;
            return t;
        }
        static double circ(double n1)
        {
            double c = Math.PI * Math.Pow(n1, 2);
            return c;
        }
        static double trap(double n1, double n2, double n3)
        {
            double t = ((n1 + n2) * n3) / 2;
            return t;
        }
        static double quad(double n1)
        {
            double q = Math.Pow(n1, 2);
            return q;
        }
        static double ret(double n1, double n2)
        {
            double r = n1 * n2;
            return r;
        }
    }
}
