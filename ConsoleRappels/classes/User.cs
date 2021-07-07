using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRappels.classes
{
    public class User
    {

        string prenom;
        string nom;
        DateTime date_naissanace;

        public User(string prenom, string nom, DateTime date_naissanace)
        {
            this.Prenom = prenom; //this.prenom = prenom;
            Nom = nom;
            Date_naissanace = date_naissanace;
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                if(value!="")
                    prenom = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public DateTime Date_naissanace
        {
            get
            {
                return date_naissanace;
            }

            set
            {
                date_naissanace = value;
            }
        }

        public override string ToString()
        {
            return prenom+" "+nom;
        }
    }
}
