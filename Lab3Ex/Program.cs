using System;

namespace Lab3Ex
{
    internal class Program
    {
        //Se citeste de la tastatura un vector continand n numere intregi, n fiind si el citit de la tastatura
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numărul de elemente din sir: ");
            int n = int.Parse(Console.ReadLine());

            int[] numere = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introdu numărul {i + 1}: ");
                numere[i] = int.Parse(Console.ReadLine());
            }

            double celMaiMareNumar = CalculeazaCelMaiMareNumar(numere);

            Console.WriteLine($"Cel mai mare numar din vector este: {celMaiMareNumar}");

            double celMaiMicNumar = CalculeazaCelMaiMicNumar(numere);

            Console.WriteLine($"Cel mai mic numar din vector este: {celMaiMicNumar}");

            AfiseazaNumereDivizibileTrei(numere);

            InverseazaVector(numere);

            CalculeazaNumerePrime(numere);
        }

        static double CalculeazaCelMaiMareNumar(int[] numere)
        {
            int celMaiMareNumar = numere[0];
            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] > celMaiMareNumar)
                    celMaiMareNumar = numere[i];
            }
            return celMaiMareNumar;
        }

        static double CalculeazaCelMaiMicNumar(int[] numere)
        {
            int celMaiMicNumar = numere[0];
            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] < celMaiMicNumar)
                    celMaiMicNumar = numere[i];
            }
            return celMaiMicNumar;
        }

        static void AfiseazaNumereDivizibileTrei(int[] numere)
        {
            Console.WriteLine("Numere care sunt divizibile cu 3:");
            foreach (var num in numere)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine($" {num}");
                }
            }
        }

        static void InverseazaVector(int[] numere)
        {
            int start = 0;
            int sfarsit = numere.Length - 1;

            Console.WriteLine("Vectorul in ordine inversa: ");

            while (start < sfarsit)
            {
                int temp = numere[start];
                numere[start] = numere[sfarsit];
                numere[sfarsit] = temp;

                start++;
                sfarsit--;
            }

            AfiseazaVector(numere);
        }

        static void AfiseazaVector(int[] numere)
        {
            foreach (var num in numere)
            {
                Console.WriteLine($" {num}");
            }
        }

        static void CalculeazaNumerePrime(int[] numar)
        {
            Console.WriteLine("Numerele prime din vector: ");
            int j;
            for (int i = 0; i < numar.Length; i++)
            {
                for (j = 2; j < numar[i]; j++)
                    if ((numar[i] % j == 0))
                    {
                        break;
                    }
                    if (j == numar[i])
                    {
                        Console.WriteLine($"{numar[i]} este prim");
                    }

            }
        }

    }
}
