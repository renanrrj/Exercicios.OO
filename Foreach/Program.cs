namespace Foreach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.WriteLine("-----------------------------------");

            foreach (string x in vet) // para cada objeto "x" contido no vetor "vet"
            { 
                Console.WriteLine(x); 
            }
        }
    }
}