using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    /// <summary>
    /// Classe Agence bancaire
    /// </summary>
    public class AgenceBancaire
    {
        // Propriétés privées
        // Liste (collection) des comptes bancaires
        private List<CompteBancaire> lesComptes;
        private string nomAgence;

        /// <summary>
        /// initialise une nouvelle instance de la classe AgenceBancaire
        /// </summary>
        /// <param name="sonNom">Le nom de l'agence</param>
        public AgenceBancaire(string sonNom)
        {
            // Création (instanciation) de la liste des comptes
            // Elle sera vide pour commencer et lesComptes.Count rencerra 0
            LesComptes = new List<CompteBancaire>();
            NomAgence = sonNom;
        }

        /// <summary>
        /// Obtient la liste des comptes
        /// </summary>
        public List<CompteBancaire> LesComptes 
        { 
            get => lesComptes; 
            set => lesComptes = value; 
        }

        /// <summary>
        /// Le nom de l'agence
        /// </summary>
        public string NomAgence 
        { 
            get => nomAgence; 
            set => nomAgence = value; 
        }

        /// <summary>
        ///  obtient le nombre de comptes gérés par l'agence
        /// </summary>
        /// <returns>Le nombre de comptes</returns>
        public int NombreComptes()
        {
            return lesComptes.Count;
        }

        /// <summary>
        /// Enregistre la création d'un nouveau compte
        /// </summary>
        /// <param name="unCompte">Le compte à ajouter</param>
        public void AjouterCompte(CompteBancaire unCompte)
        {
            lesComptes.Add(unCompte);
        }

        /// <summary>
        /// Enregistre la supression d'un compte
        /// </summary>
        /// <param name="unCompte">Le compte à supprimer</param>
        public void SupprimerCompte(CompteBancaire unCompte)
        {
            lesComptes.Remove(unCompte);
        }


    }
}
