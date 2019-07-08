using System;

namespace PrimeirosExerciciosClassesEmetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string velha;
            pessoa p1;
            pessoa p2;
            p1 = new pessoa();
            p2 = new pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            velha = maisVelha(p1.nome, p1.idade, p2.nome, p2.idade);

            Console.WriteLine($"Pessoa mais velha: {velha}");
        }

        static string maisVelha(string nomep1, int idp1, string nomep2, int idp2)
        {
            string v;

            if (idp1 > idp2)
            {
                v = nomep1;
                return v;
            }
            else
            {
                v = nomep2;
                return v;
            }

        } 
    }
}
