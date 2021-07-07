
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasesLangageConsole
{
    class Program
    {
        static String message = "Bienvenue ds .Net!";
        const String copyright = "afip@2016."; //Constante!!
        static int i;  //Variables déclarées pour la méthode ValeurDefautTest()
        static bool verif;
        static string chaine;
        static object objet;

        /*
         * Enumerations
        */
        enum jours
        {
            Dimanche,   //0  const int Dimanche=0;
            Lundi,      //1  const int Lundi=1;
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi
        };
        enum Dalton
        {   
            Joe = 158, 
            Jack = 163, 
            William = 173, 
            Averell = 185 
        }; 

        /*
         * Structures
        */
        struct Adresse
        {
            public int numero;
            public string rue;
            public int codePostal;
            public string ville;
            public string getAdresse()
            {
                return numero + ", " + rue + "\r\n" + codePostal + "\t" + ville.ToUpper();
            }
        }
        struct ClientStruct
        {
            public int code;
            public string nom;
            public string prenom;
            public Adresse coordonnees;
            public string getInfoClient()
            {
                return code + " " + prenom + " " + nom + "\r\n" + coordonnees.getAdresse();

            }
        }

        static Adresse uneAdresse; //Déclaration d'une structure
        static ClientStruct unClient;
        static ClientStruct unAutreClient;

        static void Each<T>(IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }
        static void Main(string[] args)
        {
            string[] ts = { "aa", "bb", "cc" };
            Each<String>(ts, s=>Console.WriteLine(s));


            /*
             *Affichage sur Console 
             */
            Console.WriteLine("Mon premier programme C#!!" + copyright); //Ecriture sur Console!
            Console.WriteLine(message);

            //TypeNullableTest(); // ==   Program.TypeNullableTest();
            //ConversionTest();

            StringFormatTest();
            //ConversionStringTest();
            //ValeurDefautTest();

            //Appel de la fonction Calcul
            //***************************
            //String res= Calcul(2.5f,"xxxxxxxxxx");
            //Console.WriteLine(res);

            //Console.WriteLine("Le résultat du calcul 1 est :" + Calcul(25, 10));
            //Console.WriteLine("Le résultat du calcul 2 est :" + Calcul("25", "10"));

            EnumTest();
            //TableauTest();

            //ChaineTest();
            //ComparaisonChaineTest();

            UtilisationStruct();

            //StringBuilderTest();

            SwitchIfTest();
            TableMultiplication();
            StructureUsingTest();


            Console.ReadKey();
        }

        private static void TypeNullableTest()
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Méthode pour vérifier si une variable contient la valeur Null ou non");
            Console.WriteLine("********************************************************************");
            int? CodePostal = null;
            //CodePostal =69100;
            if (CodePostal.HasValue)
            {
                Console.WriteLine(CodePostal.Value);    //Value : attribut en lecture seule
            }
            else
            {
                Console.WriteLine("Pas de valeur");
            }
            Console.WriteLine("********************************************************************");
        }
        private static void ConversionTest()
        {
            Console.WriteLine("Conversion de Types en C#:");

            //Conversion de type double vers long (sans virgule)
            double x = 21.234323;
            long y;
            Console.WriteLine("x="+x);
            //y = x;        //Impossible de convertir implicitement le type "double" en type "long"
            y = (long)x;    //..Conversion Explicite!!
            Console.WriteLine("y="+y);
            x = y;  //Possible car on peut convertir un nb sans virgule en nb à virgule facilement

            Console.WriteLine(String.Format("{0:G}", DateTime.Now));
            Console.WriteLine("********************************************************************");
        }

        //Méthode pour convertir vers une chaîne de caractères
        //****************************************************
        private static void StringFormatTest()
        {

            string s = "";
            DateTime thisDate = DateTime.Now;

            Console.Clear();

            Console.WriteLine("Formatage de valeurs numériques");
            s = String.Format(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                -123, -123.45f);
            Console.WriteLine(s);

            Console.WriteLine("Formats de date et heure");
            s = String.Format(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                "(U) Universal sortable: . . . {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n", thisDate);
            Console.WriteLine(s);


            Console.WriteLine("Formatage Enumeration");
            s = String.Format(
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F}\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n", ConsoleColor.Green);
            Console.WriteLine(s);
        }

        //Conversion depuis une chaîne de caractères
        //******************************************
        private static void ConversionStringTest()
        {
            float tva = float.Parse("18,6");
            Console.WriteLine("Tva :{0}", tva);
            //Console.WriteLine("Tva " + tva);   Ecritures équivalentes

            float tva2;
            string chaine_tva = "xxxx20,2";

            if (float.TryParse(chaine_tva, out tva2))
            {
                Console.WriteLine("conversion OK");
            }
            else
            {
                tva2=19.6f;
                Console.WriteLine("problème pendant la conversion");
            }
            Console.WriteLine("Tva " + tva2);
        }

        private static void ValeurDefautTest()
        {

            Console.WriteLine("La variable i est égale à " + i);
            Console.WriteLine("La variable verif est égale à " + verif);
            Console.WriteLine("La variable chaine est égale à " + chaine);
            Console.WriteLine("La variable objet est égale à " + objet);

            var nom = "Dupont";         //inférence de type
            Console.WriteLine(nom+" "+nom.GetType().Name);
        }
        
        private static dynamic Calcul(dynamic val1, dynamic val2)
        {
           
            //Fonction Calcul : test type 'dynamic'
            //*******************************************************
            Console.WriteLine("val1 : " + val1 + " val2 : " + val2);
            return val1 + val2;
        }

        //Méthode utilisant une énumération comme liste de variables
        //**********************************************************
        private static void EnumTest()
        {
            Dalton taille = Dalton.Joe;      //taille ne peut prendre que les valeurs de l'enum

            Console.WriteLine("Taille : " + taille);       //Affiche Joe
            Console.WriteLine("Taille : " + (int)taille);  //Affiche 158

            jours j = jours.Jeudi;
            if (j >= jours.Lundi && j<=jours.Vendredi)
            {
                Console.WriteLine("Jour de Semaine!");
            }
            else
            {
                Console.WriteLine("Week end!");
            }
        }

        private static void TableauTest()
        {
            int[] chiffreAffaires;
            chiffreAffaires = new int[12];
            //int[] chiffreAffaires= new int[12];       Autre écriture possible

            Console.WriteLine(chiffreAffaires[1]);      //Affiche 0, valeur par défaut d'un int, car pas encore de valeur entrée
            chiffreAffaires[1] = 12;
            Console.WriteLine(chiffreAffaires[1]);      //Affiche 12

            double[] tauxTVA = { 0, 5.5, 19.6, 33 };
            for (int i = 0; i < tauxTVA.Length; i++)
            {
                Console.WriteLine("TauxTVA : " + tauxTVA[i]);
            }

            foreach (double tva in tauxTVA)             //Boucle équivalente à celle ci-dessus
            {
                Console.WriteLine("Tva : " + tva);
            }

            //Taille du tableau = nombre d'éléments du tableau
            int[,] grille = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Taille du tableau : " + grille.Length);

            //Taille d'une des dimensions d'un tableau
            int[,] matrice = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("Taille de la 1re dimension : " + matrice.GetLength(0));
            Console.WriteLine("Taille de la 2e dimension : " + matrice.GetLength(1));

            //Dimension du tableau
            Console.WriteLine("Ce tableau comporte {0} dimensions", matrice.Rank);

            //Recherche d'un élément dans le tableau
            string[] gouter = { "pain", "beurre", "moutarde", "confiture" };
            Console.WriteLine("Array.IndexOf : " + Array.IndexOf(gouter, "moutarde"));

            //Tri d'un tableau dans l'ordre alphabétique
            Array.Sort(gouter);
            foreach (string plat in gouter)
            {
                Console.WriteLine(plat);
            }

        }
        private static void ChaineTest()
        {
            //Affectation d'une valeur à une chaîne
            string chaine;
            chaine = "il a dit : \" ça suffit ! \"";
            Console.WriteLine(chaine);

            //Extraction d'un caractère particulier
            string chaine2 = "L'hiver sera pluvieux !";
            Console.WriteLine("Le 3e caractère de la chaîne est : {0}", chaine2[2]);

            //Longueur d'une chaîne
            Console.WriteLine("La chaîne contient {0} caractères", chaine2.Length);

            //Découpage de chaîne
            Console.WriteLine("Un morceau de la chaîne {0} est : {1}", chaine, chaine.Substring(2, 5));

            //Insertion dans une chaîne
            string chaine3;
            chaine3 = chaine2.Insert(13, "très "); //Insertion à la 13e position
            Console.WriteLine(chaine3);

            //Suppression des espaces
            string chaine4 = " Bonjour  petit canard !  ";
            Console.WriteLine(chaine4);
            Console.WriteLine("Chaine sans espace au début : " + chaine4.TrimStart());
            Console.WriteLine("Chaine sans espace à la fin : " + chaine4.TrimEnd());
            Console.WriteLine("Chaine sans espace au début et à la fin : " + chaine4.Trim());

            //Changement de la casse
            string chaine5 = "Petit canard deviendra grand...";
            Console.WriteLine(chaine5.ToUpper());
            Console.WriteLine(chaine5.ToLower());

            Console.WriteLine("Chaine : {0}", " l'hiver sera pluvieux .".Trim().ToUpper().Insert(13, "très "));

            //Remplacement dans une chaîne
            string chaine6 = chaine2.Replace("hiver", "été");
            Console.WriteLine(chaine6);
        }

        //Méthode comparaison de chaînes
        //******************************
        private static void ComparaisonChaineTest()
        {
            string chaine1 = "Le Père Noël va me gâter cette année...";
            string chaine2 = "Le Père Noël va nous gâter cette année...";

            //Equals
            if (chaine1.Equals(chaine2))
            {
                Console.WriteLine("Les chaînes sont les mêmes");
            }
            else
            {
                Console.WriteLine("Les chaînes ne sont pas les mêmes");
            }

            //CompareTo - classement
            switch (chaine1.CompareTo(chaine2))
            {
                case -1: Console.WriteLine("Chaine1 est inférieure à Chaine2"); break;
                case 0: Console.WriteLine("Chaine1 est égale à Chaine2"); break;
                case 1: Console.WriteLine("Chaine1 est supérieure à Chaine2"); break;

            }
        }

        private static void UtilisationStruct()
        {
            uneAdresse.codePostal = 69100;
            uneAdresse.numero = 72;
            uneAdresse.rue = "Francis de Pressensé";
            uneAdresse.ville = "Villeurbanne";
            //Console.WriteLine("Adresse : {0}", adresse.getAdresse());

            unClient.code = 1;
            unClient.coordonnees = uneAdresse;
            unClient.prenom = "Bart";
            unClient.nom = "Simpson";
            Console.WriteLine("unClient : {0}", unClient.getInfoClient());

            unAutreClient = unClient;   //copie des données de unClient vers unAutreClient par valeurs
            Console.WriteLine("unAutreClient : {0}", unAutreClient.getInfoClient());
            unClient.coordonnees.codePostal = 75001;
            unClient.coordonnees.ville = "Paris";
            Console.WriteLine("unClient : {0}", unClient.getInfoClient());
            Console.WriteLine("unAutreClient : {0}", unAutreClient.getInfoClient());

         }
        private static void StringBuilderTest()
        {
            Console.WriteLine("Traitement en cours, veuillez patienter..");

            //Concaténation  avec opérateur '+'
            DateTime debut = DateTime.Now;
            string tortue = "";
            for (int i = 0; i <= 100000; i++)
            {
                tortue = tortue + " " + i;
            }
            DateTime fin = DateTime.Now;
            long duree = new TimeSpan(fin.Ticks - debut.Ticks).Seconds;

            Console.Clear();
            Console.WriteLine("durée pour la tortue : " + duree + "s"); debut = DateTime.Now;

            //Concaténation  en utilisant StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 100000; i++)
            {
                sb.Append(" ");
                sb.Append(i);
            }

            string lievre = sb.ToString();
            fin = DateTime.Now;
            duree = new TimeSpan(fin.Ticks - debut.Ticks).Seconds;
            Console.WriteLine("durée pour le lièvre : " + duree + "s");

            if (lievre.Equals(tortue))
            {
                Console.WriteLine("les deux chaines sont identiques");
            }

        }

        //Méthode pour utiliser Switch/If
        //*******************************
        private static void SwitchIfTest()
        {
            string reponse;
            Console.WriteLine("Test du CASE");
            Console.WriteLine("Votre réponse (oui/non) ?");
            reponse = Console.ReadLine();
            //SWITCH CASE
            switch (reponse)
            {
                case "oui": Console.WriteLine("Réponse positive"); break;
                case "non": Console.WriteLine("Réponse négative"); break;
                default: Console.WriteLine("Essayez encore..."); break;
            }

            //IF
            Console.WriteLine("Test du IF");
            do
            {
                Console.WriteLine("Votre réponse ?");
                reponse = Console.ReadLine();
                if (reponse.Equals("oui"))
                {
                    Console.WriteLine("Réponse positive");
                }
                else if (reponse.Equals("non"))
                {
                    Console.WriteLine("Réponse négative");
                }
                else
                {
                    Console.WriteLine("Essayez encore...");
                }
            }
            while (!reponse.Equals("oui"));
        }

        //Méthode Tables de multiplication
        //********************************
        private static void TableMultiplication()
        {
            Console.WriteLine("Tables de multiplication :");
            Console.WriteLine();

            int k;
            for (k = 1; k < 10; k++)
            {
                for (int l = 1; l < 10; l++)
                {
                    Console.Write(k * l + "\t");
                }
                Console.WriteLine();
            }
        }

        //Méthode Structure using
        //***********************
        private static void StructureUsingTest()
        {
            string path = "file_tests.txt";    //Crée le fichier dans Références/Bin/Debug
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("rouge");
                sw.WriteLine("vert");
                sw.WriteLine("bleu");
            }
            //Libération objet 'sw'!!
        }


    }
}
