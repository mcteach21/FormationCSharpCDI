using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.banque
{
    class Operation
    {
        double montant;
        TypeMvt type_mvt;
        DateTime date;
        string observations;

        public Operation(double montant, TypeMvt type_mvt, string observations)
        {
            this.montant = montant;
            this.type_mvt = type_mvt;
            this.date = DateTime.Now;
            this.observations = observations;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1} {2}",date,(type_mvt==TypeMvt.Credit?1:-1)*montant,observations);
        }

        /*
        public double Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        internal TypeMvt Type_mvt
        {
            get { return type_mvt; }
            set { type_mvt = value; }
        }
        public string Observations
        {
            get { return observations; }
            set { observations = value; }
        }
        */

    }
}
