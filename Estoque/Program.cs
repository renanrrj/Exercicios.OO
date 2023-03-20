namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do priduto: ");
            Console.Write("Nome :");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int Adc = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(Adc);

            Console.WriteLine("Dados ATUALIZADOS: " + p);


            Console.WriteLine("Digite o numero de produtos a ser Removidos ao estoque: ");
            int Rmv = int.Parse(Console.ReadLine());
            p.RemoverProdutos(Rmv);

            Console.WriteLine("Dados ATUALIZADOS: " + p);

        }
    }
}