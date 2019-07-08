using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacaoAula78Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int register = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 0; i < register; i++)
            {
                Console.WriteLine($"Employee: #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                list.Add(new Employees(id, name, salary));
            }
            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase : ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == idIncrease);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
