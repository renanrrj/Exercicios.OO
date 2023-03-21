using System.Security.Cryptography.X509Certificates;

namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa cnta;

            Console.Write("Entre com o numero da conta: "); // nao pode ser alterado
                int Conta = int.Parse(Console.ReadLine()); // variaveis temporarias
            Console.Write("Entre com o titular da conta: ");
                string Nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial?: ");
                char Resp = char.Parse(Console.ReadLine());

            if (Resp == 'S' || Resp == 's') // conta com deposito inicial
            {
                Console.WriteLine("Entre com o deposito inicial: R$");
                double depInicial = double.Parse(Console.ReadLine());
                    cnta = new Pessoa(Conta, Nome, depInicial);
            }
            else
            {
                cnta = new Pessoa(Conta, Nome); // conta sem deposito inicial
            }
           
            Console.WriteLine("Dados da conta: " +  cnta.ToString());

            Console.WriteLine();

            Console.Write("Entre com um valor para depoisto: R$");
                double qta =double.Parse(Console.ReadLine());            
                cnta.Deposito(qta);
            Console.WriteLine("Dados da conta ATUALIZADOS: " + cnta);

                    Console.WriteLine();

            Console.Write("Entre com um valor para saque: R$");
            double qtasq = double.Parse(Console.ReadLine());
            cnta.Saque(qtasq);
            Console.WriteLine("Dados da conta ATUALIZADOS: " + cnta);


        }
    }
}