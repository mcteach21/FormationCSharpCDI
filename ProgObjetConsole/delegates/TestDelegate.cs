using ProgObjetConsole.classes;
using System;

namespace ProgObjetConsole.delegates
{
    class TestDelegate
    {
        //Déclaration d'un Delegate ==== prototype de méthodes (Type)!!
        delegate int Comparaison(Client c1, Client c2) ;
        delegate void Display(Client[] tablo);

        //Déclaration d'objets de Type 'Comparaison'!!
        Comparaison comparateur1, comparateur2;
        
        public TestDelegate() {
            //Création - Affectation des Objets delegate!
            comparateur1 = new Comparaison(compareCode);
            comparateur2 += compareNom;

        }

        public void Trier(){
            Client c1= new Client("Victor","Hugo",new DateTime(),"",1500);
            Client c2= new Client("JB","Poclain",new DateTime(),"",1000);
            Client c3 = new Client("Dan", "Brown", new DateTime(), "", 2500);
            Client c4 = new Client("Marcel", "Pagnol", new DateTime(), "", 2000);
            Client c5 = new Client("Guy", "de Maupassant", new DateTime(), "", 3500);
            Client c6 = new Client("George", "Sand", new DateTime(), "", 4000);
            Client[] clients = new Client[] {c1,c2,c3,c4,c5,c6 };
            
            Console.WriteLine("Clients Avant Tri : ");
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }

            TriDelegate(clients, comparateur1);

            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Clients Après Tri : 'comparateur1' (/Code) ");
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }

            TriDelegate(clients, comparateur2);

            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Clients Après Tri : 'comparateur2' (/Nom) ");
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }
            //int res = comparateur1(c1, c2); //comparateur1.Invoke(c1, c2);
            //int res2 = comparateur2(c1, c2);
            //Console.WriteLine("Comparateur1(c1, c2) = {0}", res);
            //Console.WriteLine("Comparateur2(c1, c2) = {0}", res2);

            //Expression Lambda!!!
            //Comparaison cmp = (Client x, Client y) => { return x.Prenom.CompareTo(y.Prenom); };
            TriDelegate(clients, (x, y) =>  x.Prenom.CompareTo(y.Prenom));

            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Clients Après Tri : Expression Lambda (/Prenom) ");
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Méthode de TRI avec Delegate 'comparateur' en argument : stratégie de comparaison
        /// </summary>
        /// <param name="tablo"></param>
        /// <param name="comparateur"></param>
        private static void TriDelegate(Client[] tablo, Comparaison comparateur)
        {
            Client o;
            for (int i = 0; i < tablo.Length - 1; i++)
            {
                for (int j = i + 1; j < tablo.Length; j++)
                {
                    if (comparateur.Invoke(tablo[j], tablo[i]) < 0)
                    {
                        o = tablo[j]; tablo[j] = tablo[i]; tablo[i] = o;
                    }
                }
            }
        }
        public static int compareCode(Client c1, Client c2)
        {
            if (c1.Code < c2.Code) { return -1; }
            if (c1.Code > c2.Code) { return 1; }
            else { return 0; }
        }
        public static int compareNom(Client c1, Client c2)
        {
            return c1.Nom.CompareTo(c2.Nom);
        }

    }
}
