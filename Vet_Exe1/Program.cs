using System;

namespace Vet_Exe1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospede[] vet = new Hospede[10]; // Criação do vetor VET para armazenamento

            Console.Write("Quantos quartos serão alugados? ");
                int n = int.Parse(Console.ReadLine());           


            for (int i = 0; i < n; i++) // FOR para preenchimeto do vetor VET
            {
                Console.Write("Nome: ");
                    string nm = Console.ReadLine();

                Console.Write("Email: ");
                    string mail = Console.ReadLine();

                Console.Write("Quarto: ");
                    int qt = int.Parse(Console.ReadLine());

                vet[qt] = new Hospede (nm, mail);  
                

            }

            Console.WriteLine("Quartos ocupados");

            for (int i = 0; i < 10; i++) // FOR para leitura e apresentação dos dados do vetor VET
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }

        }
    }
}