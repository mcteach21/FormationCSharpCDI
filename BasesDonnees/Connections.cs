using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BasesDonnees
{
    public class Connections
    {
        //Récup. chaine de connection ds fichier config. App.Config !
        static string connectionString =
            ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;

        static SqlConnection connection = null; //Objet de Connection à SQl Server!
                                                //static SqlCommand command;
                                                //static SqlDataReader lecteur;

        public static void CreateConnection()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("**************Connection Northwind***********");

            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);   //Création Connection vers SQL Server                                                                        //connection.StateChange += connection_StateChange;   //Gérer Evenement Changement de Statut!
                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();   //Ouverture Connection vers BDD SQLServer
                }

                Console.WriteLine("Connection OK!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors connection : " + e.Message);
            }


            //connection.Close();

            Console.WriteLine("*********************************************");
        }

        public static void FermerConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
                connection = null;
            }
        }
        public static void LireDonnees()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************Lecture Données: Produits***************");

            SqlCommand command = connection.CreateCommand();    //  Création Objet xxxCommand pour Executer Requêtes!
            command.CommandText = "SELECT * FROM Products ORDER BY ProductID";  // ..Associer requete SQL

            SqlDataReader lecteur = command.ExecuteReader();  //..Execution Requête attachée!
            Console.WriteLine("Liste Produits : ");
            Console.WriteLine("ID\tNom Produit");

            while (lecteur.Read()) //Lire Enregistrement tant que pas Fin (=>false!)
            {
                //for (int i = 0; i < lecteur.FieldCount; i++)
                //{
                //    Console.Write(lecteur.GetValue(i) + "\t | ");
                //}
                //Console.WriteLine();
                Console.WriteLine("{0} \t {1}", lecteur.GetInt32(0), lecteur.GetString(1));
            }

            Console.WriteLine("****************************************************");
        }
    }
}
