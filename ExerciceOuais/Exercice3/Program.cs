using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mois;

            // Saisir les mois
            Console.WriteLine("saisir un mois :");
            mois = Int32.Parse(Console.ReadLine());

            // Demande si le mois est entre 12 et 1
            if (mois <= 12 && mois >= 1)
            {
                Console.WriteLine("Le mois est correct");
            }
            // On demande si le mois est supérieur a 12 et inférieur à 1
            else if (mois > 12 || mois < 1)// on aurait pu rien mettre aussi
            {
                Console.WriteLine("Le mois existe pas");
            }

            Console.ReadKey();


        }
    }
}
