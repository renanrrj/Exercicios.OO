namespace Triangulo
{
    // A Classe "Triangulo" tem 3 Atributos (lado A, lado B e lado C)
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // Médoto é uma função dentro da classe
        public double CalculoArea() // não teve parametro de entrada pois vai usar os atributos já na classe (A, B, C)
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}