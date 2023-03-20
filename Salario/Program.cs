namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;

            Pessoa p1 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da Segunda pessoa");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p2.Salario = int.Parse(Console.ReadLine());

            m = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salário médio é: " + m);

        }
    }
}