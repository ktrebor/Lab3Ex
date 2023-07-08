using System;

namespace Lab3Ex3
{
    internal class Program
    {
        /*Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu un cuvant:");
            string cuvant = Console.ReadLine();

            if (EstePalindrom(cuvant))
            {
                Console.WriteLine($"{cuvant} ESTE palindrom");
            }
            else
            {
                Console.WriteLine($"{cuvant} NU ESTE palindrom");
            }
        }

        static bool EstePalindrom(string cuvant)
        {
            int start = 0;
            int sfarsit = cuvant.Length - 1;

            while (start < sfarsit)
            {
                if (cuvant[start] != cuvant[sfarsit])
                    return false;

                start++;
                sfarsit--;
            }

            return true;
        }
    }
}
