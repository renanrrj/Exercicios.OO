using System.Collections.Generic;

namespace Lista // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> Lista = new List<string> ();

            List <string> Lista2 = new List<string> { "Maria", "Alex", "João" };

            Lista.Add ("Maria"); // adiciona ao final da lista
            Lista.Add ("Alex");
            Lista.Add ("Bob");
            Lista.Add ("Ana");

            Lista.Insert (2, "Marco"); // adciciona na posição indicada no primeiro parametro

            

            foreach (string s in Lista)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Contador de lista: " + Lista.Count); // Conta a lista
        }
    }
}