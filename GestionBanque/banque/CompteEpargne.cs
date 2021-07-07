using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.banque
{
    class CompteEpargne : Compte
    {
        double taux_abondement;
        public double Taux_abondement
        {
            get { return taux_abondement; }
        }

        public CompteEpargne(string proprietaire, double solde_depart, double taux_abondement)
            : base(proprietaire, solde_depart)
        {
            this.taux_abondement = taux_abondement;
        }

        protected override bool checkSolde(double montant_debit)
        {
            return true;
        }

        protected override double getTaux()
        {
            return taux_abondement;
        }
    }
}
