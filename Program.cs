using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Fonction
    {
        // fonction qui ne retourne aucune valeur => void
        static void disBonjour()
        {
            Console.WriteLine("Bonjour !");
        }


        // fonction qui ne retourne aucune valeur (void) et prend un paramètre en entrée
        static void tableMultiplication(int V2)
        {
            for (int V1 = 0; V1 < 11; V1++)
            {
                Console.WriteLine(V1 + "*" + V2 + "=" + (V1 * V2));
            }
        }

        // fonction qui retourne une valeur (int) et prend un paramètre en entrée (int v2)
        static int factoriel(int V2)
        {
            int fact = 1;
            int valeur = V2;

            while (V2 > 0)
            {
                fact = fact * V2;
                V2 = V2 - 1;
            }
            return fact;
        }

        // fonction qui prend un paramètre facultatif
        static void afficherInformationPersonnel(int age, string nom, float taille = 0) // taille est un paramètre facultatif toujours mis en fin de ligne
        {
            Console.WriteLine("Vous vous appelez "+nom+", vous avez "+age+" votre taille est "+taille);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("----------------Multiplication---------------------- ");

            Console.WriteLine("Veuillez entrer le chiffre à multiplier par 10");
            int nombre = int.Parse(Console.ReadLine());

            tableMultiplication(nombre);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("----------------Factorisation----------------");
            Console.WriteLine("Veuillez entrer le chiffre à factoriser: ");
            int nombre2 = int.Parse(Console.ReadLine());

            int resultat = factoriel(nombre2);

            Console.WriteLine(resultat);

            // Console.WriteLine(factoriel(nombre2));
            // Les deux solutions sont possible [ resultat retourne la même valeur que Console.WriteLine(factoriel(nombre2));

            afficherInformationPersonnel(18, "Moroko");

            afficherInformationPersonnel(18, "Moroko", 1.90F);
        }
    }
}