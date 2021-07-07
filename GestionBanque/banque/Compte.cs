using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.banque
{
    abstract class Compte
    {
        //Déclaration Evenement de Gestion du Découvert!!
        private event EventHandler<DecouvertEventArgs> gestionDecouvertEvent;
        
        double solde;
        public double Solde
        {
            get { return solde; }
        }
        string proprietaire;
        public string Proprietaire
        {
            get { return proprietaire; }
        }
        List<Operation> operations = new List<Operation>();


        public Compte(string proprietaire, double solde_depart)
        {
            this.proprietaire = proprietaire;
            this.solde = solde_depart;
            
            Operation op=new Operation(solde_depart, TypeMvt.Credit, "Ouverture compte..");
            this.operations.Add(op);

            //gestionDecouvertEvent = new EventHandler<DecouvertEventArgs>(Gestion_Decouvert);
            gestionDecouvertEvent += Gestion_Decouvert;
        }

        protected void Gestion_Decouvert(Object source, DecouvertEventArgs e)
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("**************************ATTENTION!!!!**************************");
            Console.WriteLine("Compte [{0}] - Solde {1}",e.Client, e.Solde);
            Console.WriteLine("Opération Débit [-{0}] à la date {1} impossible!!", e.Montant_debit, e.Date);
            Console.WriteLine("*****************************************************************");
        }

        /// <summary>
        /// CREDITS
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public void Crediter(double montant)
        {
            if (this is CompteEpargne)
            {
                montant = montant * (1 + ((CompteEpargne)this).Taux_abondement);
            }
            solde += montant;

            solde= Math.Round(solde, 2);

            operations.Add(new Operation(montant, TypeMvt.Credit, "crédit sur compte.."));
            Console.WriteLine("**********************************************");
            Console.WriteLine("Crédit [{0}€] effectué avec succès : {1} ", montant, this);
            Console.WriteLine("**********************************************");
        }

        protected abstract double getTaux();

        public void Crediter(double montant, Compte compte_a_debiter)
        {
            if (compte_a_debiter.Debiter(montant))
            {
                Crediter(montant);
            }
        }

        /// <summary>
        /// DEBITS
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public bool Debiter(double montant)
        {
            if (!checkSolde(montant))
            {
                //Probleme de Decouvert ===> Déclenchement Evenement!!!!!
                gestionDecouvertEvent(this, new DecouvertEventArgs(this.proprietaire, this.solde, montant));

                return false;
            }
            solde -= montant;

            solde = Math.Round(solde, 2);
            operations.Add(new Operation(montant, TypeMvt.Debit, "débit sur compte.."));

            Console.WriteLine("**********************************************");
            Console.WriteLine("Débit [-{0}€] effectué avec succès : {1} ",montant, this);
            Console.WriteLine("**********************************************");
            return true;
        }
        public bool Debiter(double montant, Compte compte_a_crediter)
        {
            if (this.Debiter(montant))
            {
                compte_a_crediter.Crediter(montant);
                return true;
            }
            return false;
        }
        protected abstract bool checkSolde(double montant_debit);

        public override string ToString()
        {
            string compte = (this is CompteCourant) ? "Compte Courant" : "Compte Epargne";
            return String.Format("{0} [{1}] - Solde Courant : {2}.", compte, proprietaire, solde);
        }

        public void Resume()
        {
            Console.WriteLine(this);
            Console.WriteLine("Liste Opérations : ");
            foreach (var op in operations)
            {
                Console.WriteLine("\t{0}", op);
            }
        }
    }
}
