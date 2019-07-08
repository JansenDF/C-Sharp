using System;
using System.Globalization;

namespace Exercicio3ClassesAtributosEMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.NotaFinal = a.CalcularNotaFinal();

            Console.WriteLine($"NOTA FINAL = {a.NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{a}");
        }
    }
}
