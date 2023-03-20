namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f);

            Console.Write("Digite a porcentagem de aumento de salário: ");
            int porc = int.Parse(Console.ReadLine());
            f.AumentarSalario(porc);

            Console.WriteLine("Dados Atualizados: " + f);

        }
    }
}