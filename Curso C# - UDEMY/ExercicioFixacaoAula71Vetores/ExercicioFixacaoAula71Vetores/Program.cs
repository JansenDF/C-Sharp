using System;

namespace ExercicioFixacaoAula71Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Room[] vect = new Room[10];

            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Alugue #{i+1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());

                vect[q] = new Room (nome, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i=0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}
