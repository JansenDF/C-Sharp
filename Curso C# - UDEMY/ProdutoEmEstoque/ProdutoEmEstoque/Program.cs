using System;
using System.Globalization;

namespace ProdutoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qtdAdd = int.Parse(Console.ReadLine());
            p.Add(qtdAdd);

            Console.WriteLine($"Dados do produto: {p}");
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int qtdRem = int.Parse(Console.ReadLine());
            p.Remover(qtdRem);

            Console.WriteLine($"Dados do produto: {p}");
        }
    }
}
