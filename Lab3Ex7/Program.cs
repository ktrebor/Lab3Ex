using System;

namespace Lab3Ex7
{
    internal class Program
    {
        /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati o si afisati i rezultatul.*/
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int suma = AdunaNumere(n);
            Console.WriteLine($"Suma numerelor de la 1 la {n}: {suma}");
        }

        static int AdunaNumere(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n + AdunaNumere(n - 1);
            }
        }
    }
}
