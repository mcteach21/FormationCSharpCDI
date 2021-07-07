using GestionBanque.banque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    class Menu
    {
        private static event EventHandler<CompteEventArgs> gestionCompteEvent;
        static void Main(string[] args)
        {

            gestionCompteEvent += Menu_gestionCompteEvent;
            int choix=0;
            
            do
            {
                choix = DisplayMenu(choix == 0);
                switch (choix)
                {
                    case 1:
                        creerCompte();
                        break;
                    case 2:
                        resumeCompte();
                        break;
                    case 3:
                        crediterCompte();
                        break;
                    case 4:
                        debiterCompte();
                        break;
                    case 5:
                        resumeBanque();
                        break;
                    default:
                        if(choix!=6)
                            choix = 0;
                        break;
                }

            }
            while (choix!=6);

            Console.WriteLine("Gestion Bancaire : Quitter..");
            Console.ReadKey();
        }

        static void Menu_gestionCompteEvent(object sender, CompteEventArgs e)
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*********EVENT 'Gestion Compte' : ATTENTION!!!!******************");
            Console.WriteLine("Compte déjà existant pour Client : {0}!", e.Client);
            Console.WriteLine("*****************************************************************");
        }

        private static void creerCompte()
        {
            Console.WriteLine("*************************Création Nouveau Compte*************************");
            double solde_depart, decouvert_autorise, taux_abondement;
            string choix_compte;

            choix_compte = lireClavier("Saisir Type de compte : 1-Courant ou 2-Epargne");
            while (!choix_compte.Equals("1") && !choix_compte.Equals("2"))
            {
                choix_compte = lireClavier("..Type de compte : 1-Courant ou 2-Epargne");
            }

            string nom = lireClavier("Saisir nom client");
            bool meme_cpte;
            //Test et Event Event.
            if (Banque.Comptes.Count > 0)
            {
                foreach (var cpte in Banque.Comptes)
                {
                    meme_cpte = (cpte is CompteCourant && choix_compte.Equals("1")) || (cpte is CompteEpargne && choix_compte.Equals("2"));

                    if (meme_cpte && cpte.Proprietaire.ToLower().Equals(nom.ToLower()))
                    {
                        
                        gestionCompteEvent(null, new CompteEventArgs(nom));
                        return;
                    }
                }
            }

            double.TryParse(lireClavier("Saisir Solde de départ").Replace('.',','), out solde_depart);
            Compte compte;
            if (int.Parse(choix_compte) == 1)
            {
                //Compte courant
                double.TryParse(lireClavier("Saisir montant découvert autorisé").Replace('.', ','), out decouvert_autorise);
                compte = new CompteCourant(nom, solde_depart, decouvert_autorise);
            }
            else
            {
                //..Epargne
                double.TryParse(lireClavier("Saisir taux d'abondement [x.x %]").Replace('.', ','), out taux_abondement);
                compte = new CompteEpargne(nom, solde_depart, (double)taux_abondement/100);
            }

            Banque.Comptes.Add(compte);
            Console.Write("Création Compte effectuée avec succès ==> ");
            Console.WriteLine(compte);

        }

        private static Compte choixCompte(string titre)
        {
            Compte compte = null;
            int nb = Banque.Comptes.Count;
            if (nb > 0)
            {
                resumeBanque();

                int num;
                int.TryParse(lireClavier("Choix Compte N° [" + titre + "] ===>"), out num);
                if (num > 0 && num <= nb)
                {
                    compte = Banque.Comptes[num - 1];
                }
            }
            else
            {
                Console.WriteLine("Aucun compte créé!");
            }
            return compte;
        }
        private static void resumeCompte()
        {
            Compte compte = choixCompte("Résumé");
            if(compte!=null)
                compte.Resume();
        }
        private static void debiterCompte()
        {
            Compte compte = choixCompte("A Débiter");
            if (compte != null)
            {
                double montant;
                if (double.TryParse(lireClavier("Saisir montant débit ").Replace('.', ','), out montant))
                {

                    string rep = lireClavier("Créditer autre compte?(o/N)? ");
                    if (rep.ToLower().Equals("o"))
                    {
                        Compte compte_a_crediter = choixCompte("A Créditer");
                        if (compte != compte_a_crediter)
                        {
                            compte.Debiter(montant, compte_a_crediter);
                        }
                        else
                        {
                            Console.WriteLine("Compte à créditer et débiter identiques! Opération annulée.");
                        }
                    }
                    else
                    {
                        compte.Debiter(montant);
                    }

                    
                }
            }
        }
        private static void crediterCompte()
        {
            Compte compte = choixCompte("A Créditer");
            if (compte != null)
            {
                double montant;
                if (double.TryParse(lireClavier("Saisir montant crédit ").Replace('.', ','), out montant))
                {

                     string rep = lireClavier("Créditer à partir autre compte?(o/N)? ");
                     if (rep.ToLower().Equals("oui"))
                     {
                         Compte compte_a_debiter = choixCompte("A Débiter");
                         if (compte != compte_a_debiter)
                         {
                            compte.Crediter(montant, compte_a_debiter);
                         }
                         else
                         {
                             Console.WriteLine("Compte à créditer et débiter identiques! Opération annulée.");
                         }
                     }
                     else
                     {
                         compte.Crediter(montant);
                     }
                }
            }
        }
        private static void resumeBanque()
        {
            int i=1;
            Console.WriteLine("*********************************************");
            if (Banque.Comptes.Count == 0)
            {
                Console.WriteLine("Aucun Compte créé!");
            }
            else
            {
                Console.WriteLine("Liste Comptes : ");
                foreach (var compte in Banque.Comptes)
                {
                    Console.WriteLine(i + "-" + compte); i++;
                }
            }
            Console.WriteLine("*********************************************");
        }
        private static int DisplayMenu(bool complet)
        {
            int choix;

            if (complet)
            {
                Console.WriteLine(" ***************************************************************");
                Console.WriteLine(" ********** Gestion Banque ==> Choisir Opération : *************");
                Console.WriteLine(" ********** 1. Création Compte *********************************");
                Console.WriteLine(" ********** 2. Consulter Compte (Résumé) ***********************");
                Console.WriteLine(" ********** 3. Opération de Crédit *****************************");
                Console.WriteLine(" ********** 4. Opération de Débit ******************************");
                Console.WriteLine(" ********** 5. Banque : Liste Comptes **************************");
                Console.WriteLine(" ********** 6. Quitter *****************************************");
                Console.WriteLine(" ***************************************************************");

                Console.Write("===> : ");
            }
            else
            {
                Console.Write("Choix Menu ===> : ");
            }
            int.TryParse(Console.ReadLine(), out choix);
            return choix;
        }

        private static string lireClavier(string message)
        {        
            string saisie;
            do
            {
                Console.Write(message + " : ");
                saisie = Console.ReadLine();
            }
            while (saisie.Equals(""));
            return saisie;
        }
    }
}
