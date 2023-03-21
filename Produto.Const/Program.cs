using System.Globalization;

namespace Produto.Const
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
            p.SetNome("445345");
            p.GetPreco();
            
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());

            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
        }
    }
}