using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioPropostoAula136.Entities;

namespace ExercicioPropostoAula136
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Contribuinte #{i}: ");
                Console.Write("Pessoa FISICA ou JURIDICA (f/j): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Rendimento anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'f')
                {
                    Console.Write("Desesas com saúde: ");
                    double despesaSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Fisica(nome, rendaAnual, despesaSaude));
                }
                else
                {
                    Console.Write("Numero de empregados: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());

                    list.Add(new Juridica(nome, rendaAnual, numeroFuncionarios));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxas pagas:");
            foreach(Pessoa pessoa in list)
            {
                Console.WriteLine($"{pessoa.Nome} $ {pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();
            double soma = 0.0;
            foreach (Pessoa total in list)
            {
                soma += total.Imposto();
            }
            Console.WriteLine($"Total de imposto: {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
