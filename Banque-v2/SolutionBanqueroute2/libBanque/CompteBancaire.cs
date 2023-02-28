using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    /// <summary>
    /// classe CompteBancaire
    /// </summary>
    public class CompteBancaire
    {
        #region Propriétés privées de la classe
        // Propriete privees
        private string numCompte;
        private string nomTitulaire;
        private decimal soldeCompte;
        #endregion

        #region Property = Acesseurs et mutateurs
        /// <summary>
        /// le numéro du compte bancaire
        /// </summary>
        public string NumCompte
        {
            get => numCompte;
            set => numCompte = value;
        }

        /// <summary>
        /// le nom du titulaire du compte bancaire
        /// </summary>
        public string NomTitulaire
        {
            get => nomTitulaire;
            set => nomTitulaire = value;
        }

        /// <summary>
        /// le solde du compte bancaire
        /// </summary>
        public decimal SoldeCompte
        {
            get => soldeCompte;
        }
        #endregion

        #region Constructeur  de la classe
        /// <summary>
        /// initialise une nouvelle instance de la classe CompteBancaire
        /// </summary>
        /// <param name="sonNumero">Le numéro du compte bancaire</param>
        /// <param name="sonTitulaire">le titulaire du compte bancaire</param>
        public CompteBancaire(string sonNumero, string sonTitulaire)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = 0;
        }

        /// <summary>
        /// initialise une nouvelle instance de la classe CompteBancaire
        /// </summary>
        /// <param name="sonNumero">Le numéro du compte bancaire</param>
        /// <param name="sonTitulaire">le titulaire du compte bancaire</param>
        /// <param name="sonSoldeInitial">le solde du compte bancaire</param>
        public CompteBancaire(string sonNumero, string sonTitulaire, decimal sonSoldeInitial)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = sonSoldeInitial;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Permet de débiter un certain montant sur le compte choisi
        /// </summary>
        /// <param name="montant">montant à débiter sur le compte</param>
        /// <returns></returns>
        public bool DebiterCompte(decimal montant)
        {
            bool resultat = false;
            if (montant < soldeCompte)
            {
                resultat = true;
                soldeCompte -= montant;
            }

            return resultat;
        }

        /// <summary>
        /// Permet de crediter un compte
        /// </summary>
        /// <param name="montant">Le montant de la transaction</param>
        /// <returns></returns>
        public bool CrediterCompte(decimal montant)
        {
            bool resultat = false;
            if (montant > 0)
            {
                resultat = true;
                soldeCompte += montant;
            }
            return resultat;
        }
        #endregion




    }
}
