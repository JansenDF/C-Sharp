using System.Globalization;

namespace ProdutoEmEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        public double ValorEmEstoque()
        {
            return Preco * Qtde;
        }
        public void Add(int qtd)
        {
            Qtde += qtd;
        }
        public void Remover(int qtd)
        {
            Qtde -= qtd;
        }
        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, quantidade em estoque: {Qtde}, valor total: {ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
