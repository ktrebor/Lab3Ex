using System;

namespace Lab3Ex6
{
    internal class Program
    {
        /*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni
        avand lungimile n m, respectiv m,n L ungimile celor doua dimensiuni ale
        matricilor , m si n , vor fi citite de la tastaura .
 */
        static void Main()
        {
            Console.WriteLine("Introdu dimensiunile matricilor:");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriceaUnu = new int[n, m];
            int[,] matriceaDoi = new int[m, n];

            Console.WriteLine($"Ai introdus {m} coloane si {n} randuri pentru prima matrice si {n} coloane si {m} randuri pentru a doua matrice");

            Console.WriteLine("Introdu numerele pentru prima matrice:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Numar pentru prima matrice cu pozitia: [{i},{j}] = ");
                    matriceaUnu[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Introdu numerele pentru a doua matrice:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Numar pentru a doua matrice cu pozitia: [{i},{j}] = ");
                    matriceaDoi[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] produsulMatricei = InmultesteMatrice(matriceaUnu, matriceaDoi, n, m);
            Console.WriteLine("Produsul celor doua matrici:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(produsulMatricei[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] InmultesteMatrice(int[,] matriceaUnu, int[,] matriceaDoi, int n, int m)
        {
            int[,] produsulMatricei = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        produsulMatricei[i, j] += matriceaUnu[i, k] * matriceaDoi[k, j];
                    }
                }
            }

            return produsulMatricei;
        }
    }
}
