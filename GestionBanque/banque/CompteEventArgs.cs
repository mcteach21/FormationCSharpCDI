using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBanque.banque
{
    class CompteEventArgs: EventArgs
    {
        string client;
        DateTime date;

        public CompteEventArgs(string _client)
        {
            this.client = _client;
            this.date = DateTime.Now;

        }

        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
