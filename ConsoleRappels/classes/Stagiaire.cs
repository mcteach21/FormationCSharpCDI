using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRappels.classes
{
    //Herite de la classe 'User' et Implemente l'interface 'ICompare'
    class Stagiaire : User, ICompare
    {
        //Variable de Classe (Statique!)
        static int cpteur = 0;
        public static int Cpteur
        {
            get
            {
                return cpteur;
            }
        }
        //Var. d'Instance!!!
        string formation;
        public Stagiaire(string prenom, string nom, DateTime date_naissance, string formation)
            :base(prenom, nom, date_naissance) //Appel du constructeur classe Mère (de Base!)
        {
            Formation = formation;  //..specifique
            cpteur++;
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Formation;
        }

        //implementer méthode de l'interface 'ICompare'
        public int compare(object o)
        {
            if (o is Stagiaire)
            {
                Stagiaire s = (Stagiaire)o; //Convertir o en Stagiaire
                
                return this.Prenom.CompareTo(s.Prenom);
            }
            else {
                return -99;
            }
        }

        public string Formation
        {
            get
            {
                return formation;
            }

            set
            {
                formation = value;
            }
        }


    }
}
