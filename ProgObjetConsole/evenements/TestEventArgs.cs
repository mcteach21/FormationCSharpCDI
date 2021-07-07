using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgObjetConsole.evenements
{
    class TestEventArgs : EventArgs
    {
        int num_cmde;
        DateTime date_cmde;
        
        public TestEventArgs(int num_cmde, DateTime date_cmde)
        {
            this.num_cmde = num_cmde; this.date_cmde = date_cmde;
        }
        public int Num_cmde
        {
            get { return num_cmde; }
        }
        public DateTime Date_cmde
        {
            get { return date_cmde; }
        }

    }
}
