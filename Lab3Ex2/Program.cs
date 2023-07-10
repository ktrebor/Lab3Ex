using System;

namespace Lab3Ex2
{
    internal class Program
    {
        static void Main()
        {
            /*Scrieti un program care va afisa pozitia unui substring intr un string, ambele siruri de caractere fiind citite de la tastatura*/
            Console.WriteLine("Introdu o propozitie:");
            string text = Console.ReadLine();

            Console.WriteLine("Introdu un caracter sau un text din propozitie:");
            string substring = Console.ReadLine();

            int pozitia = GasestePozitieSubstring(text, substring);

            if (pozitia != -1)
            {
                Console.WriteLine($"Substringul \"{substring}\" se află la pozitia {pozitia} în sirul de caractere.");
            }
            else
            {
                Console.WriteLine($"Substringul \"{substring}\" nu a fost gasit in sirul de caractere.");
            }
        }

        static int GasestePozitieSubstring(string text, string substring)
        {
            return text.IndexOf(substring);
        }
    }
}
