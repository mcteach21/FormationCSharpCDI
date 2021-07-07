using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.classes
{
    public partial class Personne
    {
        string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private Personne[] enfants = new Personne[5];
        public Personne this[int index]
        {
            get{ return enfants[index]; }
            set{ enfants[index] = value; }
        }
    }
}
