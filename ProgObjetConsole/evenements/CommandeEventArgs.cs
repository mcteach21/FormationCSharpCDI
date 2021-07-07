using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.evenements
{
    class CommandeEventArgs : EventArgs
    {
        int num_cmde;
        double montant;
        DateTime date_cmde;
        public int Num_cmde
        {
            get { return num_cmde; }
        }
        public double Montant
        {
            get { return montant; }
        }
        public DateTime Date_cmde
        {
            get { return date_cmde; }
        }

        public CommandeEventArgs(int num_cmde, double montant, DateTime date_cmde)
        {
            this.num_cmde = num_cmde; this.montant = montant; this.date_cmde = date_cmde;
        }
    }
}
