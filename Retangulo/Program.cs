namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area());
            Console.WriteLine("Perimetro " + r.Perimetro());
            Console.WriteLine("Diagonal " + r.Diagonal());
        }
    }
}}