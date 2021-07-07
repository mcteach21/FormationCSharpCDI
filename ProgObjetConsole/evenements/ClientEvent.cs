using ProgObjetConsole.classes;
using System;

namespace ProgObjetConsole.evenements
{
    class ClientEvent : Personne
    {
        static int nbcmdes = 0;

        // 1 - Déclaration Evenement!!!
        private event EventHandler MaxCommandeEvent;
        private event EventHandler<CommandeEventArgs> MaxCommandePlusEvent;

        private event EventHandler<TestEventArgs> CmdeXCommandeEvent;

        public ClientEvent()
        {
            //2- Associer Gestionnaire(S) d'Evenements!
            MaxCommandeEvent += ClientEvent_MaxCommandeEvent;
           
            //MaxCommandeEvent = new EventHandler(ClientEvent_MaxCommandeEvent);

            MaxCommandePlusEvent += ClientEvent_MaxCommandePlusEvent;
            //MaxCommandePlusEvent += ClientEvent_2MaxCommandeEvent;


            CmdeXCommandeEvent += ClientEvent_CmdeXCommandeEvent;
        }

        void ClientEvent_CmdeXCommandeEvent(object sender, TestEventArgs e)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("=========>Déclenchement de mon Evenement 'Cmde 5000!' à la date : " + e.Date_cmde);
            Console.WriteLine("********************************************************************");
        }

        //void ClientEvent_2MaxCommandeEvent(object sender, CommandeEventArgs e)
        //{
        //    Console.WriteLine("********************************************************************");
        //    Console.WriteLine("Méthode 2=========>Déclenchement de mon Evenement par l'objet : " + sender.ToString());
        //    Console.WriteLine("********************************************************************");
        //}
          
        /// <summary>
        /// Gestionnaire Evenement : MaxCommandeEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClientEvent_MaxCommandeEvent(object sender, EventArgs e)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("=========>Déclenchement de mon Evenement par l'objet : "+sender.ToString());
            Console.WriteLine("********************************************************************");
        }

        void ClientEvent_MaxCommandePlusEvent(object sender, CommandeEventArgs e)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("=====>Déclenchement de mon Evenement - Cmde {0} Montant {1} Date {2}", e.Num_cmde, e.Montant, e.Date_cmde);
            Console.WriteLine("********************************************************************");
        }

        public void AjoutCommande(int num_cmde, double montant)
        {
            Console.WriteLine("Ajout commande numéro..{0} - montant {1}", num_cmde, montant);
            if (montant >= 1000) { 
                CommandeEventArgs e= new CommandeEventArgs(num_cmde,montant, DateTime.Now);
                // Déclenchement de mon Evenement!!
                MaxCommandePlusEvent(this, e);
            }

            if (num_cmde == 5000)
                ClientEvent_CmdeXCommandeEvent(this, new TestEventArgs(num_cmde, DateTime.Now));
        }
        public void AjoutCommande(int num_cmde)
        {
            Console.WriteLine("Ajout commande numéro..{0}", num_cmde);

            //traitement de la commande...
            nbcmdes++;
            // Déclenchement de mon Evenement!!
            if (nbcmdes >=10)
            {
                MaxCommandeEvent(this, new EventArgs());
            }
        }
    }
}
