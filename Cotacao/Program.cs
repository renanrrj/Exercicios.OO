namespace Cotacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares irá comprar? ");
            double dolares = double.Parse(Console.ReadLine());

            //double circ = Calculadora.Circunferencia(raio);
            double cota = Cotacao.ValorTotal(cotacao, dolares);


            Console.WriteLine("Valor a ser pago em reais = R$" + cota.ToString());

        }
    }
}
