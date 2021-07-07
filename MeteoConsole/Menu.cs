using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoConsole
{
    class Menu
    {
        static void Main(string[] args)
        {
            int choix = 0;
            int nbre = 0;

            SimuMeteo.Init();
            do
            {
                choix = DisplayMenu(choix == 0);
                switch (choix)
                {
                    case 1:

                        int.TryParse(lireClavier("Saisir nombre de simulations"), out nbre);
                        if(nbre>0)
                            SimuMeteo.Generer(nbre);
                        break;
                    case 2:
                        SimuMeteo.Rapport();
                        break;
                    default:
                        if (choix != 3)
                            choix = 0;
                        break;
                }

            }
            while (choix != 3);

            Console.WriteLine("Simulateur Meteo : Quitter..");
            Console.ReadKey();
        }
        private static int DisplayMenu(bool complet)
        {
            int choix;

            if (complet)
            {
                Console.WriteLine(" ***************************************************************");
                Console.WriteLine(" ********** Simulateur Meteo ==> Choisir Opération :************");
                Console.WriteLine(" ********** 1. Simulateur Temps ********************************");
                Console.WriteLine(" ********** 2. Afficher Rapport ********************************");
                Console.WriteLine(" ********** 3. Quitter *****************************************");
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
