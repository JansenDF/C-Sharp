using System;
using System.Globalization;

namespace ExercicioPropostoAula24_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int qtd1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = (qtd1*valor1) + (qtd2*valor2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
