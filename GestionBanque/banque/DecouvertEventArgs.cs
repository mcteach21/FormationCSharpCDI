using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBanque.banque
{
    class DecouvertEventArgs : EventArgs
    {
        //Classe contenant des informations sur l'event!
        string client;
        double solde, montant_debit;
        DateTime date;

        public DecouvertEventArgs(string _client,  double _solde, double _montant_debit){
            this.client = _client;
            this.solde = _solde;
            this.montant_debit = _montant_debit;
            this.date = DateTime.Now;

        }

        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public double Montant_debit
        {
            get { return montant_debit; }
            set { montant_debit = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
