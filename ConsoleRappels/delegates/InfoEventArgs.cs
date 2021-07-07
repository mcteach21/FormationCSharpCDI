using System;

namespace ConsoleRappels.delegates
{
    class InfoEventArgs : EventArgs
    {
        int negatif;
        public InfoEventArgs(int negatif)
        {
           Negatif = negatif;
        }

        public int Negatif
        {
            get
            {
                return negatif;
            }

            set
            {
                if(value<0)
                    negatif = value;
            }
        }
    }
}