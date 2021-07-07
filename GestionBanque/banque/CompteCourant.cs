using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.banque
{
    class CompteCourant : Compte
    {
        double decouvert_autorise;

        public CompteCourant(string proprietaire, double solde_depart, double decouvert_autorise)
            : base(proprietaire, solde_depart)
        {
            this.decouvert_autorise = decouvert_autorise;
        }

        protected override bool checkSolde(double montant_debit)
        {
            bool debit_ok = (this.Solde + this.decouvert_autorise >= montant_debit);
            /*if (!debit_ok)
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine(this+" | découvert autorisé : {0}" ,decouvert_autorise);
                Console.WriteLine("====>Opération Débit [-{0}] annulée : solde insuffisant!", montant_debit);
                Console.WriteLine("*****************************************************");
            }*/
            return debit_ok;
        }

        protected override double getTaux()
        {
            return 0.0;
        }
    }
}
