using System;
using System.Collections.Generic;

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

            int[] divizibileCuTrei = CalculeazaNumereDivizibileTrei(numere);
            Console.WriteLine($"Numerele care sunt divizibile cu 3: ");
            AfiseazaVector(divizibileCuTrei);

            int[] vectorInversat = InverseazaVector(numere);
            Console.WriteLine($"Vectorul inversat: ");
            AfiseazaVector(vectorInversat);

            int[] vectorNumerePrime = CalculeazaNumerePrime(numere);
            Console.WriteLine($"Numere prime din vector: ");
            AfiseazaVector(vectorNumerePrime);
        }

        static void AfiseazaVector(int[] numere)
        {
            foreach (var num in numere)
            {
                Console.WriteLine($" {num}");
            }
        }

        //Cel mai mare numar din vector
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

        //Cel mai mic numar din vector
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

        //numere divizibile cu 3
        static int[] CalculeazaNumereDivizibileTrei(int[] numere)
        {
            List<int> divizibileCuTrei = new List<int>();

            foreach (var num in numere)
            {
                if (num % 3 == 0)
                {
                    divizibileCuTrei.Add(num);
                }
            }

            return divizibileCuTrei.ToArray();
        }

        //Scrieti o functie care va inversa elementele vectorului
        static int[] InverseazaVector(int[] numere)
        {
            int start = 0;
            int sfarsit = numere.Length - 1;

            while (start < sfarsit)
            {
                int temp = numere[start];
                numere[start] = numere[sfarsit];
                numere[sfarsit] = temp;

                start++;
                sfarsit--;
            }

            return numere;
        }

        //Numerele prime din vector
        static int[] CalculeazaNumerePrime(int[] numere)
        {
            List<int> numerePrime = new List<int>();

            foreach (var num in numere)
            {
                bool estePrim = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        estePrim = false;
                        break;
                    }
                }

                if (estePrim && num > 1)
                {
                    numerePrime.Add(num);
                }
            }

            return numerePrime.ToArray();

        }
    }
}
