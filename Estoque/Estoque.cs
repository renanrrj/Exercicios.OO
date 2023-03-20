namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
