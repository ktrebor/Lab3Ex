using System;

namespace Lab3Ex5
{
    internal class Program
    {
        /*Screiti un program care va numara vocalele dintr un sir de caractere citit de la tastatura*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu un cuvant sau o propozitie: ");

            string propozitie = Console.ReadLine();

            int rezultat = NumaraVocale(propozitie);

            Console.WriteLine($"Numarul tuturor vocalelor: {rezultat}");
        }

        static int NumaraVocale(string propozitie)
        {
            int contor = 0;
            string vocale = "aeiouAEIOU";

            foreach(char litera in propozitie)
            {
                if (vocale.Contains(litera))
                {
                    contor++;
                }
            }

            return contor;
        }

    }
}
