using System;

namespace Lab3Ex4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdu o propozitie: ");
            
            string propozitie = Console.ReadLine();

            string rezultat = TransformaPrimaLiteraMareDinCuvant(propozitie);

            Console.WriteLine(rezultat);
        }

        static string TransformaPrimaLiteraMareDinCuvant(string propozitie)
        {
            //sparg stringul in cuvinte separate
            string[] cuvinte = propozitie.Split(' ');

            for (int i = 0; i < cuvinte.Length; i++)
            {
                string cuvant = cuvinte[i];

                if (!string.IsNullOrEmpty(cuvant))
                {
                    string primaLitera = cuvant.Substring(0, 1);
                    string restulCuvantului = cuvant.Substring(1).ToLower();
                    cuvinte[i] = primaLitera.ToUpper() + restulCuvantului;
                }
            }

            //returnez cuvintele intr-un singur string
            return string.Join(" ", cuvinte);
        }
    }
}
