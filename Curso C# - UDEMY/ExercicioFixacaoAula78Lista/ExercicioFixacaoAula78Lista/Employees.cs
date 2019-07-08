using System.Globalization;

namespace ExercicioFixacaoAula78Lista
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porc)
        {
            Salary += Salary * porc / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}
