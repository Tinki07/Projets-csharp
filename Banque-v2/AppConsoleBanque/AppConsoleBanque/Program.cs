using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libBanque;

namespace AppConsoleBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création d'un objet CompteBancaire
            CompteBancaire unCompte = new CompteBancaire("lol", "loulou", 1000);

            //Affichage du contenu des propriétés
            Console.WriteLine("Numéro du compte : " + unCompte.NumCompte);
            Console.WriteLine("Titulaire du compte : " + unCompte.NomTitulaire);
            Console.WriteLine("Solde du compte : " + unCompte.SoldeCompte);

            //Test de la valeur du titulaire
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
            CompteBancaire cbPatrirck = new CompteBancaire("0211651079B", "M. MARTIN Patrick");
            CompteBancaire cbMathilde = new CompteBancaire("1234212312D", "Mme NOUVEAU Mathilde", 1500.00m);

            // Consultation des comptes avant opérations
            Console.WriteLine();
            Console.WriteLine("Consultation du compte " + cbPatrirck.NumCompte + " de " + cbPatrirck.NomTitulaire + " ;");
            Console.WriteLine(" -> Solde : " + cbPatrirck.SoldeCompte);
            Console.WriteLine();
            Console.WriteLine("Consultation du compte " + cbMathilde.NumCompte + " de " + cbMathilde.NomTitulaire + " ;");
            Console.WriteLine(" -> Solde : " + cbMathilde.SoldeCompte);
            Console.WriteLine();

            // Test des méthodes
            cbMathilde.CrediterCompte(1000);
            Console.WriteLine(" -> Solde après le crédit : " + cbMathilde.SoldeCompte);
            Console.WriteLine();

            cbMathilde.DebiterCompte(2000);
            Console.WriteLine(" -> Solde après le débit : " + cbMathilde.SoldeCompte);
            Console.WriteLine();

            // Ajoute de l'objet agence
            AgenceBancaire agence = new AgenceBancaire("Agence Tours");

            // Ajout des 2 comptes bancaire
            agence.AjouterCompte(cbMathilde);
            agence.AjouterCompte(cbPatrirck);
 
            // Affiche le nombre de comptes dans l'agence
            Console.WriteLine("il y a : " + agence.NombreComptes() + " comptes dans l'" + agence.NomAgence);
            Console.WriteLine();

            // Affiche les informations des comptes dans l'agence
            foreach(CompteBancaire compte in agence.LesComptes)
            {
                Console.WriteLine("- Numéro : " + compte.NumCompte + ", " + compte.NomTitulaire + 
                    ", avec un solde de : " + compte.SoldeCompte + " euros");
            }

            Console.ReadKey();
        }
    }
}
