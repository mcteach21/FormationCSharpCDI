using BasesDonneesConsole.dao;
using System;

namespace BasesDonneesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*****************Bases de Données*******************");

            //Connections.ListeFournisseurs();    //Liste Providers disponibles
            //Connections.SeConnecter();          //Se Connecter à la BD. (Northwind)

            //Requetes SELECT..
            //Connections.LectureDonnees();
            //Connections.LectureDonnesScalar();
            //Connections.LectureDonneesParam();

            //Requetes Actions..
            //Connections.InsererDonnees();
            //Connections.ModifierDonnees();
            //Connections.SupprimerDonnees();

            //Exo..
            //Connections.AjoutCategorie();

            //Procédure Stockée..
            //Connections.ProcStockeeTotalClient();
            //Connections.ProcStockeeCmdesClient();

            // **************************************************** //
            // **************** Mode Non Connecté!                  //
            ModeNonConnecte mnc = new ModeNonConnecte();
            //mnc.RemplirDataSet();
            //mnc.Remplir2DataSet();
            //mnc.RemplirDataSetNoDB();

            mnc.DataSetUpdateDB();

            Console.WriteLine("une touche pour sortir..");
            Console.ReadKey();
            Console.WriteLine("****************************************************");
        }
    }
}
