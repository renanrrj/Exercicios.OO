namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) // Obrigado a entrar com esses dados (Construtor sempre após os atributos)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int adc)
        {
            Quantidade += adc;
        }
        public int RemoverProdutos(int rmv)
        {
            return Quantidade -= rmv;
        }
        public override string ToString() // Sobreposição 
        {
            return Nome + ", R$" + Preco + ", " + Quantidade + " Unidades, R$" + ValorTotalEstoque();
        }
    }
}