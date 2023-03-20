namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do priduto: ");
            Console.Write("Nome :");
            string nm = Console.ReadLine(); // variavel auxiliar
            Console.Write("Preco: ");
            double pr = int.Parse(Console.ReadLine());
            //Console.Write("Quantidade: ");
            //int qt = int.Parse(Console.ReadLine());

            Produto p = new Produto(nm, pr); // Por conta do Construtor, sou obrigado a entrar com valores. Através de variaveis auxiliares (nm, pr, qt)

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