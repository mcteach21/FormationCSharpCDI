using ProgObjetConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.classes
{
    class Stagiaire : Personne // herite de 'Personne' qui implemente l'interface 'IComparaison'
    {
        List<String> liste_dynam = new List<string>();

        public Stagiaire(string prenom, string nom, DateTime _date_naissance, string adresse)
            :base(prenom, nom, _date_naissance, adresse)
        {
            //liste_dynam.Add("xxxxxxxxxx");
            //liste_dynam.Add("zzzzzzzzzz");
            foreach (var item in liste_dynam)
            {
                Console.WriteLine(item);
            }
        }

        //Substitution de la méthode 'compare' de 'Personne' (contrat imposé par l'interface!!)
        public override int compare(object o)
        {
            if (o is Stagiaire)
            {
                Stagiaire s = (Stagiaire)o;
                return this.Date_naissance.Year < s.Date_naissance.Year ? -1 : (this.Date_naissance.Year > s.Date_naissance.Year ? 1 : 0);
            }
            return -99;
        }
        
    }
}
