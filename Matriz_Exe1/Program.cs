namespace Matrtiz_Exe1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Tamanho da matiz: ");
            int ln = int.Parse(Console.ReadLine());
            int cl = int.Parse(Console.ReadLine());

            int[,] mat = new int[ln, cl];

            for (int l = 0; l < ln; l++)
            {
                string [] vet = Console.ReadLine().Split (' ');   // Cria um vetor de armazenamento temporário dos dados             

                for (int c = 0; c < cl; c++)
                {
                    mat[l, c] = int.Parse(vet[c]); // Converte a string do vetor "vet" em int e coloca na posição "c" da linha e coluna
                }
            }


        }
    }
}