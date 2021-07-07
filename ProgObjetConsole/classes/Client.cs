using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.classes
{
    class Client: Personne
    {
        int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public Client(string prenom, string nom , DateTime date_naissance, string adresse, int code)
            : base(prenom, nom, date_naissance, adresse)
        {
            this.code = code;
        }
        public override string ToString()
        {
            return this.Code+" "+ base.ToString();
        }
    }
}
