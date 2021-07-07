using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoConsole
{
    enum Temps
    {
        Soleil,
        Nuages,
        Pluie,
        Orages
    }
    class SimuMeteo
    {
        private static event EventHandler<MeteoEventArgs> MeteoChangeEvent;
          
        static List<int> simulation;
        static int nb_soleil;

        public static void Init()
        {
            MeteoChangeEvent += SimuMeteo_MeteoChangeEvent;
        }
        static void SimuMeteo_MeteoChangeEvent(object sender, MeteoEventArgs e)
        {
            Console.WriteLine(" ****** Changement Temps : {0} => {1} ******",e.Temps_prec,e.Temps_actuel);
        }
        public static void Generer(int nbre_simu)
        {

            simulation = new List<int>();
            nb_soleil = 0;

            Temps temps, temps_prec=Temps.Soleil;
            Random alea = new Random();
            int nb_alea ;

            Console.WriteLine("***********************************************");
            for (int i = 0; i < nbre_simu; i++)
            {
                nb_alea = alea.Next(0, 100);
                simulation.Add(nb_alea);

                if (nb_alea < 40) { temps = Temps.Soleil; }
                else if (nb_alea < 50) { temps = Temps.Nuages; }
                else if (nb_alea < 90) { temps = Temps.Pluie; }
                else { temps = Temps.Orages; }

                if (i > 0 && temps != temps_prec)
                {
                    Console.Write("=>{0} [{1}] ", temps, nb_alea);
                    DeclencherChgtTemps(temps, temps_prec);
                }else{
                    Console.WriteLine("=>{0} [{1}] ", temps, nb_alea);
                }
                                
                nb_soleil += (temps == Temps.Soleil ? 1 : 0);

                temps_prec = temps;
                
            }
            Console.WriteLine("***********************************************");
        }

        private static void DeclencherChgtTemps(Temps temps_actuel, Temps temps_prec)
        {
            MeteoChangeEvent("Simu.", new MeteoEventArgs(temps_actuel, temps_prec));
        }
        public static void Rapport()
        {
            double prc = (double)nb_soleil / (double)simulation.Count;
            Console.WriteLine(" ***************************************************************");
            Console.WriteLine(" **************** Simulateur Meteo ==> Rapport :****************");
            Console.WriteLine(" Soleil {0} fois - {1}%", nb_soleil, Math.Round(prc * 100,2));
            Console.WriteLine(" ***************************************************************");
        }

    }
}
