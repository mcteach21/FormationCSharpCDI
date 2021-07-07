using System;

namespace ConsoleRappels.classes
{
    class Formateur : User, ICompare
    {
        string specialite;
        public Formateur(string prenom, string nom, DateTime date_naissance, string specialite)
            : base(prenom, nom, date_naissance) //Appel du constructeur classe Mère (de Base!)
        {
            Specialite = specialite;  //..specifique
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Specialite;
        }

        public int compare(object o)
        {
            if (o is Formateur)
            {
                Formateur f = (Formateur)o; //Convertir o en Stagiaire

                return this.Nom.CompareTo(f.Nom);
            }
            else {
                return -99;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
            }

            set
            {
                specialite = value;
            }
        }
    }
}
