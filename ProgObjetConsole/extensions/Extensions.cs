using ProgObjetConsole.classes;
using System;

namespace ProgObjetConsole.extensions
{
    static class Extensions
    {
        /// <summary>
        /// Méthode d'Extension pour ts les objets de type Personne!
        /// </summary>
        /// <param name="p"></param>
        public static void fiche(this Personne p)
        {
            Console.WriteLine("Nom : {0}", p.Nom);
            Console.WriteLine("Prénom : {0}", p.Prenom);
            Console.WriteLine("Date de naissance : {0}", p.Date_naissance);
        }
        public static string formater(this String s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }

    }
}
