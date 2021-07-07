using ProgObjetConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.classes
{
    /*
     * Classe 'Partielle' : répartie sur plusieurs fichiers source
     */ 
    public partial class Personne : IComparaison
    {
        private static int compteur = 0;
        public static int Compteur
        {
            get { return Personne.compteur; }
        }
        private string prenom; 
        private string nom;     
        private DateTime date_naissance;
      
        //Constructeur 
        public Personne() : this("Bob", "Leponge", new DateTime(1970, 1, 1), "")
        {
            //this.prenom = "Bob";   //this.nom = "Leponge";  //this.date_naissance = new DateTime(1970, 1, 1);
        }
        public Personne(string prenom, string nom, DateTime _date_naissance, string adresse)
        {
            this.prenom = prenom;  this.nom = nom;  this.date_naissance = _date_naissance; this.adresse = adresse;
            compteur++;
        }

        //Propriétés : getters / setters
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public DateTime Date_naissance
        {
            get { return date_naissance; }
            set
            {
                if (value.Year >= 1900) // .. La date de naissance ne sera pas inférieure à 1900
                {
                    date_naissance = value;
                }
            }
        }

        /// <summary>
        /// Méthode Calcul age
        /// </summary>
        /// <returns>int</returns>
        public int calculAge()
        {
            return DateTime.Now.Year - Date_naissance.Year;
        }

        /// <summary>
        /// Méthode Autorisant la Subsitution (mot clé : virtual)
        /// </summary>
        public virtual void affichage()
        {
            Console.WriteLine("Mr {0} {1} né le {2}", nom, prenom, date_naissance);
        }
        public void affichage(string langue)
        {
            switch (langue)
            {
                case "fr":
                    Console.WriteLine("Mr {0} {1} né le {2}", nom, prenom, date_naissance);
                    break;
                case "en":
                    Console.WriteLine("Mr {0} {1} was born {2}", nom, prenom, date_naissance);
                    break;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2} habitant {3}", prenom, nom, date_naissance, adresse);
        }


        //Implementation Interface 'IComparaison'
        public virtual int compare(object o)
        {
            if (o is Personne)
            {
                Personne p = (Personne)o;
                return this.Nom.CompareTo(p.Nom);
            }

            return -99;
        }
    }
}
