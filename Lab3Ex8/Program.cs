using System;

namespace Lab3Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu un numar intreg si pozitiv n: ");
            int n = int.Parse(Console.ReadLine());

            AfiseazaPiramidaNumerelor(n);
        }

        static void AfiseazaPiramidaNumerelor(int n)
        {
            if (n <= 0)
            {
                return;
            } 

            AfiseazaPiramidaNumerelor(n - 1);

            for (int i = 0; i < n; i++)
            {
                Console.Write(n);
            }

            Console.WriteLine();
        }
    }
}
