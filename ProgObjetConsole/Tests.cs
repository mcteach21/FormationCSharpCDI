using System;
using ProgObjetConsole.classes;
using ProgObjetConsole.extensions;
using ProgObjetConsole.interfaces;
using ProgObjetConsole.evenements;
using ProgObjetConsole.delegates;
using ProgObjetConsole.generique;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ProgObjetConsole
{
    class Tests
    {
        /*
         * Classe Principale du Projet : Tests!
         */ 
        static void Main(string[] args)
        {

            //TestPersonne();
            //TestSubstitution();
            //TestExtensions();

            //TestInterface();
            //TestTri();

            //TestEvenements();

            //Tests Delegate
            //TestDelegate td = new TestDelegate();
            //td.Trier();

            //TestGenerique();
            //TestCollections();
            //Console.WriteLine("Nombre personnes : " + Personne.Compteur);
            Console.ReadKey();
        }

        private static void TestCollections()
        {
            Hashtable hashtable = new Hashtable();
            
            hashtable["c1"] = new Client ("cl1", "pren1", new DateTime(1964, 12, 23),"", 1001) ;
            hashtable["c2"] = new Client ("cl2", "pren2", new DateTime(1974, 12, 23),"", 1002) ;
            hashtable["s3"] = new Stagiaire("cl3", "pren3", new DateTime(1974, 12, 23), "");

            Console.WriteLine("Hashtable : ");
            foreach (DictionaryEntry entry in hashtable)
            {

                Type classe = entry.Value.GetType(); //Recup. Classe Objet
                try
                {
                    //Reflection!!
                    object value = classe.GetProperty("Nom").GetValue(entry.Value);
                    Console.WriteLine("{0}, {1}", entry.Key, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : {0}", e.Message);
                }
               

                //if (entry.Value is Client)
                //    Console.WriteLine("{0}, {1}", entry.Key, ((Client)entry.Value).Nom);
                //else
                //    Console.WriteLine("{0}, {1}", entry.Key, ((Stagiaire)entry.Value).Nom);
            }

            Dictionary<String, Client> dico = new Dictionary<string, Client>();

            dico["c1"] = new Client ("cl1", "pren1", new DateTime(1964, 12, 23),"", 1001) ;
            dico["c2"] = new Client ("cl2", "pren2", new DateTime(1974, 12, 23),"", 1002) ;
            Console.WriteLine("Dictionary : ");
            foreach (KeyValuePair<string, Client> pair in dico)
            {
                Console.WriteLine("{0}, {1}", pair.Key, ((Client)pair.Value).Nom) ;
            }
        }
        private static void TestGenerique()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************Liste Generique****************");
            ListeGenerique<Client> liste1 = new ListeGenerique<Client>(2);
            liste1.ajout(new Client("Marcel", "Stendhal", new DateTime(1895, 1, 1), "xxx", 10));
            liste1.ajout(new Client("Victor", "Hugo", new DateTime(1895, 1, 1), "xxx", 20));
            liste1.ajout(new Client("JJ", "Rousseau", new DateTime(1895, 1, 1), "xxx", 30));

            Console.WriteLine("Premier : {0}", liste1.premier());
            Console.WriteLine("Dernier : {0}", liste1.dernier());

            ListeGenerique<Stagiaire> liste2 = new ListeGenerique<Stagiaire>(2);
            liste2.ajout(new Stagiaire("Marcel", "Stendhal", new DateTime(1895, 1, 1), "xxx"));
            liste2.ajout(new Stagiaire("Victor", "Hugo", new DateTime(1895, 1, 1), "xxx"));
            liste2.ajout(new Stagiaire("JJ", "Rousseau", new DateTime(1895, 1, 1), "xxx"));

            Console.WriteLine("Premier : {0}", liste2.premier());
            Console.WriteLine("Dernier : {0}", liste2.dernier());
            Console.WriteLine("**********************************************");
        }
        private static void TestEvenements()
        {
            Random rnd = new Random();
            ClientEvent ce = new ClientEvent();
            for (int i = 1; i <= 10; i++)
            {         
                ce.AjoutCommande(i*1000,(double)rnd.Next(500, 1200));
            }

        }
        private static void tri(IComparaison[] tablo)
        {
            IComparaison o;
            for (int i = 0; i < tablo.Length - 1; i++)
            {
                for (int j = i + 1; j < tablo.Length; j++)
                {
                    if (tablo[j].compare(tablo[i]) < 0) // tablo[i] ‘supérieur’ à tablo[j]
                    {
                        o = tablo[j]; tablo[j] = tablo[i]; tablo[i] = o;
                    }
                }
            }
        }
        private static void TestTri()
        {
            Personne[] liste = new Personne[4];
            liste[0] = new Personne("p_10", "Stendhal", new DateTime(), "xxx");
            liste[1] = new Personne("p_5", "Levy", new DateTime(), "xxx");
            liste[2] = new Personne("p_1", "Hugo", new DateTime(), "xxx");
            liste[3] = new Personne("p_3", "Rousseau", new DateTime(), "xxx");

            tri(liste);
            Console.WriteLine("Tableau Trié de Personnes : ");
            foreach (var personne in liste)
            {
                Console.WriteLine(personne);
            }

            Stagiaire[] liste2 = new Stagiaire[4];
            liste2[0] = new Stagiaire("Marcel", "Stendhal", new DateTime(1895,1,1), "xxx");
            liste2[1] = new Stagiaire("Victor", "Hugo", new DateTime(1890, 1, 1), "xxx");
            liste2[2] = new Stagiaire("Dan", "Brown", new DateTime(1960, 1, 1), "xxx");
            liste2[3] = new Stagiaire("Jean Baptiste", "Poclain", new DateTime(1899, 1, 1), "xxx");
            tri(liste2);
            Console.WriteLine("Tableau Trié de Stagiaires : ");
            foreach (var s in liste2)
            {
                Console.WriteLine(s);
            }

        }

        private static void TestInterface()
        {
            Personne jb1 = new Personne("Marcel", "Stendhal", new DateTime(1890, 1, 25), "1 Cours Lafayette 69003 Lyon.");
            Personne jb2 = new Personne("Momo", "Hugo", new DateTime(1899, 1, 25), "1 Cours Lafayette 69003 Lyon.");

            int res_comp= jb1.compare(jb2);
            Console.WriteLine("Resultat Comparaison {0} - {1}  : {2}",jb1.Nom,jb2.Nom, res_comp);
        }

        private static void TestExtensions()
        {
            Personne jb = new Personne("JB", "Afip", new DateTime(1990, 1, 25), "1 Cours Lafayette 69003 Lyon.");
            jb.fiche();

            string s = "mOn ConTRAt etc ETC..";
            Console.WriteLine(s.formater());
        }
        private static void TestSubstitution()
        {
            Salarie s = new Salarie("David", "Vincent", new DateTime(1940, 5, 10), "Hollywood Blvd", 175986565, "Alien And Co.");
            s.affichage();
        }
        private static void TestPersonne()
        {
            Personne jb = new Personne("JB", "Afip", new DateTime(1990, 1, 25), "1 Cours Lafayette 69003 Lyon.");
            jb.Nom = "Simpson";
            jb.Adresse = "17 rue de la convention, 75001 Paris";
            jb.Date_naissance = new DateTime(1899, 1, 1);

            Console.WriteLine("Personne : " + jb);


            Personne hs = new Personne("Homer", "Simpson", new DateTime(1970, 8, 26), "233A Springfield Iowa.");

            Personne bs = new Personne("Bart", hs.Nom, new DateTime(1990, 8, 26), "233A Springfield Iowa.");
            Personne ls = new Personne("Lisa", hs.Nom, new DateTime(1995, 8, 26), "233A Springfield Iowa.");

            hs[0] = bs;
            hs[1] = ls;

            Console.WriteLine("Homer : " + hs);
            Console.WriteLine("Ses Enfants : ");

            Console.WriteLine(hs[0]);
            Console.WriteLine(hs[1]);

            Console.WriteLine("Nombre personnes : " + Personne.Compteur);
        }
    }
}
