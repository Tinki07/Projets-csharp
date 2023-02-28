using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialisation des  variables
            int a;
            int b;
            int resultat;

            // valeurs de A et B
            Console.WriteLine("Valeur de a :");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Valeur de b :");
            b = Int32.Parse(Console.ReadLine());

            // On demande que si b est supérieru que 0 alors faire le calcul de A et B
            if (b > 0)
            {
                resultat = a/b;
                Console.WriteLine("Le résultat est : " + resultat);
            }
            else
            {
                Console.WriteLine(" Erreur");
            }
            Console.ReadKey();




        }
    }
}
