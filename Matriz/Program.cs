namespace Matriz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int c = 0; c < n; c++)
                {
                    mat[l, c] = int.Parse(vet[c]);
                }                

            }

            Console.WriteLine("Diagonal principal: ");
            for (int l = 0; l < n; l++)
            {
                Console.Write(mat[l, l] + " ");

            }

            int Count = 0; 
            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[l, c] < 0)
                    {
                        Count++;
                    }
                    
                }

            }
            Console.WriteLine();
            Console.Write( "Negativos: " + Count);


        }
    }
}