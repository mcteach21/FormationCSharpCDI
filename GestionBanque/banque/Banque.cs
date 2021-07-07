using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.banque
{
    class Banque
    {
        static List<Compte> comptes = new List<Compte>();
        internal static List<Compte> Comptes
        {
            get { return Banque.comptes; }
            set { Banque.comptes = value; }
        }

    }
}
