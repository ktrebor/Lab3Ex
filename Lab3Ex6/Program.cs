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
            
            CitesteMatrice(matriceaUnu, "prima matrice");
            CitesteMatrice(matriceaDoi, "a doua matrice");

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

        static void CitesteMatrice(int[,] matrice, string denumireMatrice)
        {
            int randuri = matrice.GetLength(0);
            int coloane = matrice.GetLength(1);

            Console.WriteLine($"Introdu numerele pentru {denumireMatrice}:");

            for (int i = 0; i < randuri; i++)
            {
                for (int j = 0; j < coloane; j++)
                {
                    Console.Write($"Numar pentru {denumireMatrice} cu pozitia: [{i},{j}] = ");
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
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
