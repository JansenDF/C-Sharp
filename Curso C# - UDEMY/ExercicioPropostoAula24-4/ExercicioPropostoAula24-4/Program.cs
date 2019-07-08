using System;
using System.Globalization;

namespace ExercicioPropostoAula24_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int numFuncionario = int.Parse(Console.ReadLine());
            float horasTrabalhadas = float.Parse(Console.ReadLine());
            float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
