using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBanque;

namespace AppConsoleBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un objet CompteBancaire
            CompteBancaires unCompte = new CompteBancaires("1","Compte1");

            // Affichage du contenu des propriétés
            Console.WriteLine("Numéro du compte : " + unCompte.NumCompte);
            Console.WriteLine("Titulaire du comtpe : " + unCompte.NomTitulaire);
            Console.WriteLine("Solde du compte : " + unCompte.SoldeComtpe);

            // Test de la valeur du titulaire
            if (unCompte.NomTitulaire == "")
            {
                Console.WriteLine("Ce que contient le nom du titulaire : une chaine vide !");
            }
            if (unCompte.NomTitulaire == null)
            {
                Console.WriteLine("Ce que contient le nom du titulaire : la valeur null !");
            }
            

            // Création des comptes
            Console.WriteLine("Création des comptes...");
            CompteBancaires cbPatrirck = new CompteBancaires("0211651079B", "M. MARTIN Patrick");
            CompteBancaires cbMathilde = new CompteBancaires("1234212312D", "Mme NOUVEAU Mathilde", 1500.00m);

            // Consultation des comptes avant opérations
            Console.WriteLine();
            Console.WriteLine("Consultation du compte " + cbPatrirck.NumCompte + " de " + cbPatrirck.NomTitulaire + " ;");
            Console.WriteLine(" -> Solde : " + cbPatrirck.SoldeComtpe);
            Console.WriteLine();
            Console.WriteLine("Consultation du compte " + cbMathilde.NumCompte + " de " + cbMathilde.NomTitulaire + " ;");
            Console.WriteLine(" -> Solde : " + cbMathilde.SoldeComtpe);
            Console.WriteLine();

            AgenceBancaire agence = new AgenceBancaire("Agence1");

            agence.AjouterCompte(cbMathilde);
            agence.AjouterCompte(cbPatrirck);

            Console.WriteLine(agence.NombreComptes());

            foreach(CompteBancaires compte in agence.LesComptes)
            {
                Console.WriteLine(compte.NumCompte + " " + compte.NomTitulaire + " " + compte.SoldeComtpe);
            }




            Console.ReadKey();
        }
    }
}
