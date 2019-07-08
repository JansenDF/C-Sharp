using System;

namespace ExercicioFixacaoMatrizesAula81
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] mat = new int[n, m];

            for (int i=0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j=0; j < m; j++)
                {
                    mat[i, j] = int.Parse(input[j]);
                }
            }
            int wanted = int.Parse(Console.ReadLine());

            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    {
                        if (mat[i, j] == wanted)
                        {
                            Console.WriteLine($"Position {i},{j}");
                            if ((j - 1) >= 0)
                            {
                                Console.WriteLine($"Left: {mat[i, j - 1]}");
                            }
                            if ((j + 1) <= m)
                            {
                                Console.WriteLine($"Right: {mat[i, j + 1]}");
                            }
                            if ((i - 1) >= 0)
                            {
                                Console.WriteLine($"Down: {mat[i - 1, j]}");
                            }
                            if ((i + 1) <= n)
                            {
                                Console.WriteLine($"Up: {mat[i + 1, j]}");
                            }
                        }
                    }
                }
            }
        }
    }
}
