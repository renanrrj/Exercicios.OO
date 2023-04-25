using System;
using System.Runtime.Serialization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // variável que recebe o numero de repetição

            Produto[] vet = new Produto[n]; // Criação do vetor de nome "vet"

            for (int i = 0; i < n; i++) // FOR para preencher 
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vet[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) // FOR para somar o campo soma do objeto vet.
            {
                soma += vet[i].Preco;
            }

            double med = soma / n;
            Console.WriteLine("Media: " + med);


        }

    }
}