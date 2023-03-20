namespace Cotacao
{
    internal class Cotacao
    {
        public static double Iof = 6.0;
        public static double ValorTotal(double cota, double dol)
        {
            double result = cota * dol;
            return result + result * Iof / 100;
        }
    }
}
