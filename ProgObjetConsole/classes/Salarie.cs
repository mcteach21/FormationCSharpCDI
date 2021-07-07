using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.classes
{
    class Salarie : Personne 
    {
        int nss;
        string entreprise;

        public Salarie(string prenom, string nom, DateTime _date_naissance, string adresse, int nss, string entreprise)
            :base(prenom, nom, _date_naissance, adresse) //Appel du Constructeur Classe Mere!!!
        {
            this.nss = nss;
            this.entreprise = entreprise;
        }

        /// <summary>
        /// Méthode de Subsitution (mot clé : override)
        /// </summary>
        public override void affichage()
        {
            //1 : Masquer affiuchage au dessus
            //Console.WriteLine("Méthode Substituée 'Affichage' dans 'Salarie'!");
            //Console.WriteLine("Mr {0} {1} né le {2}", Nom, Prenom, Date_naissance);

            //2 appel de la méthode affichage de la c lasse Personne
            base.affichage();
            // ajout des fonctionnalités spécifiques à la classe Salarie
            Console.WriteLine("Il travaille dans l'entreprise :  {0}.", entreprise);
        }
    }
}
