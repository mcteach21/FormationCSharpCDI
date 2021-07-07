using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeteoConsole
{
    class MeteoEventArgs : EventArgs
    {
        Temps temps_actuel, temps_prec;

        public MeteoEventArgs(Temps temps_actuel, Temps temps_prec)
        {
            this.temps_actuel = temps_actuel;
            this.temps_prec = temps_prec;
        }
        internal Temps Temps_prec
        {
            get { return temps_prec; }
        }

        internal Temps Temps_actuel
        {
            get { return temps_actuel; }
        }

    }
}
