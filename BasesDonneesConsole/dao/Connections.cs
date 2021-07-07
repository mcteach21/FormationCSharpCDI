using System;
using System.Configuration;     //Ajouter Référence System.Configuration !!
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BasesDonneesConsole.dao
{
    public class Connections
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["NorthwindSqlConnection"].ConnectionString;
        static SqlConnection connection = null;
        static SqlCommand command;
        static SqlDataReader lecteur;

        public static void ListeFournisseurs()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Liste Fournisseurs Dispo.*************");

            DataTable resultat = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow ligne in resultat.Rows)
            {
                Console.WriteLine("{0} [{1}]",ligne["InvariantName"],ligne["Name"]);
            }

            Console.WriteLine("****************************************************");
        }

        public static void CreateConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);   //Création Connection
                connection.StateChange += connection_StateChange;   //Gérer Evenement Changement de Statut!
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();   //Ouverture Connection vers BDD SQLServer
            }
        }
        public static void CloseConnection()
        {
            if (connection != null)
                connection.Close();  //Fermeture Connection
        }
        static void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Closed:
                    Console.WriteLine("[Event!]Fermeture Connection..");
                    break;
                case ConnectionState.Open:
                    Console.WriteLine("[Event!]Ouverture Connection..");
                    break;
                case ConnectionState.Connecting:
                    Console.WriteLine("[Event!]Connection en Connection..");
                    break;
                case ConnectionState.Executing:
                    break;
                case ConnectionState.Fetching:
                    break;
                case ConnectionState.Broken:
                    break;
                default:
                    break;
            }
        }
        public static void SeConnecter()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*************Connection Northwind*******************");

            ////Récupération chaine de connection à partir App.Config (Fichier de Configuration)
            //var connectionString = ConfigurationManager.ConnectionStrings["NorthwindSqlConnection"].ConnectionString;
            //Console.WriteLine("Chaine de Connection : "+connectionString);

            //IDbConnection connection;   // Interface pour déclarer l'objet Connection
            ////Création objet connection de type 'SQL Server'! (spécifique!!)
            //connection = new SqlConnection(connectionString);

            CreateConnection();
            Console.WriteLine("..utilisation Base de Données..");
            CloseConnection();
            Console.WriteLine("****************************************************");
        }

        //Utilisation Base de Données
        public static void LectureDonneesParam()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*********Lecture Données - Paramètres***************");
            CreateConnection();

            command = connection.CreateCommand();
            Console.Write("Saisir le code du client recherché : ");
            string codeClient = Console.ReadLine();

            command.CommandText = "SELECT @nbCmd=count(orderid) from orders where customerid=@code";

            SqlParameter paramCodeClient = new SqlParameter("@Code", codeClient);
            paramCodeClient.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramCodeClient);

            SqlParameter paramNbCommandes = new SqlParameter("@nbCmd", SqlDbType.Int);
            paramNbCommandes.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramNbCommandes);

            lecteur = command.ExecuteReader();
            Console.WriteLine("Le client {1} a passé {0} commande(s)", command.Parameters["@nbCmd"].Value, codeClient);

            CloseConnection();
            Console.WriteLine("****************************************************");
        }

        public static void LectureDonnesScalar()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************Lecture Données Scalar******************");
            CreateConnection();

            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(orderid) FROM orders WHERE customerid='FRANK'";
            //Récuperation Donnée Simple (Nombre)!
            Console.WriteLine("Le client FRANK a passé {0} commande(s)", command.ExecuteScalar());

            CloseConnection();
            Console.WriteLine("****************************************************");
        }

        public static void LectureDonnees()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************Lecture Données: Produits***************");
            CreateConnection();

            IDbCommand command = connection.CreateCommand();                    //  Création Objet xxxCommand pour Executer Requêtes!
            command.CommandText = "SELECT * FROM Products ORDER BY ProductID";  // ..Associer requete SQL

            IDataReader lecteur = command.ExecuteReader();  //..Execution Requête attachée!
            Console.WriteLine("Liste Produits : ");

            //for (int col = 0; col < lecteur.FieldCount; col++)
            //{
            //    Console.Write(lecteur.GetName(col).ToString() + "\t | ");
            //}
            //Console.WriteLine();
            Console.WriteLine("ID\tNom Produit");
            while (lecteur.Read())
            {
                //for (int i = 0; i < lecteur.FieldCount; i++)
                //{
                //   Console.Write(lecteur.GetValue(i)+"\t | ");
                //}
                //Console.WriteLine();
                Console.WriteLine("{0} \t {1}", lecteur.GetInt32(0), lecteur.GetString(1));
            }

            CloseConnection();
            Console.WriteLine("****************************************************");
        }

        public static void InsererDonnees()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************Ecriture Données: Fournisseurs**********");

            CreateConnection(); //Ouverture Connection!!

            SqlCommand command = connection.CreateCommand();  //  Création Objet xxxCommand pour Executer Requêtes!

            command.CommandText = "INSERT INTO shippers(companyname,phone) VALUES('DHL','02 55 51 42 43')";
            Console.WriteLine("{0} ligne(s) ajoutée(s) dans la table", command.ExecuteNonQuery());

            CloseConnection();
        }
        public static void ModifierDonnees()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Update Données: Fournisseurs**********");

            CreateConnection(); //Ouverture Connection!!

            SqlCommand command = connection.CreateCommand();  //  Création Objet xxxCommand pour Executer Requêtes!

            command.CommandText = "UPDATE shippers SET companyname='DHL-AFIP' WHERE companyname like 'DHL%'";
            Console.WriteLine("{0} ligne(s) modifiée(s) dans la table", command.ExecuteNonQuery());

            CloseConnection();
        }
        public static void SupprimerDonnees()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Delete Données: Fournisseurs**********");

            CreateConnection(); //Ouverture Connection!!

            SqlCommand command = connection.CreateCommand();  //  Création Objet xxxCommand pour Executer Requêtes!

            command.CommandText = "DELETE FROM shippers WHERE companyname like 'DHL%' AND ShipperID>6";
            Console.WriteLine("{0} ligne(s) modifiée(s) dans la table", command.ExecuteNonQuery());

            CloseConnection();
        }
        private static string lectureConsole(string message)
        {
            string saisie;
            do
            {
                Console.Write(message);
                saisie = Console.ReadLine();
            } while ("".Equals(saisie));

            return saisie;
        }
        public static void AjoutCategorie()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************ Ajout Nouvelle Catégorie **************");

            string categoryName, description;
            //do
            //{
            //    Console.Write("Catégorie - Libellé : ");
            //    categoryName = Console.ReadLine();
            //} while ("".Equals(categoryName));
            categoryName = lectureConsole("Catégorie - Libellé : ");
            //do
            //{
            //    Console.Write("Catégorie - Description : ");
            //    description = Console.ReadLine();
            //} while ("".Equals(description));
            description = lectureConsole("Catégorie - Description : ");

            CreateConnection();
            SqlCommand command = connection.CreateCommand();

            //command.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES('"+ categoryName + "','"+ description + "')";

            command.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES(@name,@desc)";
            SqlParameter paramName = new SqlParameter("@name", categoryName);
            paramName.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramName);

            SqlParameter paramDesc = new SqlParameter("@desc", description);
            paramDesc.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramDesc);

            int nb = command.ExecuteNonQuery();
            if (nb > 0)
            {
                Console.WriteLine("Nouvelle Catégorie ajoutée avec succès!");
            }

            command.CommandText = "SELECT * FROM Categories ORDER BY CategoryName";  // ..Associer requete SQL
            IDataReader lecteur = command.ExecuteReader();  //..Execution Requête attachée!
            Console.WriteLine("***************************************");
            while (lecteur.Read())
            {
                Console.WriteLine("{0} : {1}",lecteur["CategoryName"], lecteur["Description"]);
            }
            Console.WriteLine("***************************************");

            CloseConnection();
        }

        public static void ProcStockeeTotalClient()
        {
            CreateConnection();
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** Procédure Stockée *******************");

            string codeClient = lectureConsole("Calcul CA - Code Client : ");

            var command = connection.CreateCommand();
            command.CommandText = "TotalClient";               //Associer Procédure Stockée
            command.CommandType = CommandType.StoredProcedure;

            var paramCodeClient = new SqlParameter("@Code", codeClient);
            paramCodeClient.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramCodeClient);

            var paramMontant = new SqlParameter("RETURN_VALUE", SqlDbType.Decimal);
            paramMontant.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(paramMontant);

            command.ExecuteNonQuery();
            Console.WriteLine("Le client '{0}' a passé pour {1} Euros de commandes.", codeClient, paramMontant.Value);

            Console.WriteLine("****************************************************");
            CloseConnection();
        }
        public static void ProcStockeeCmdesClient() //Exo
        {
            CreateConnection();
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** Procédure Stockée *******************");

            string codeClient = lectureConsole("Nombre Commandes - Code Client : ");

            //Nbre
            var command = connection.CreateCommand();
            command.CommandText = "CmdesClient";   //Associer Procédure Stockée
            command.CommandType = CommandType.StoredProcedure;

            var paramCodeClient = new SqlParameter("@Code", codeClient);
            paramCodeClient.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramCodeClient);

            var cmdesNbre = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
            cmdesNbre.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(cmdesNbre);
            command.ExecuteNonQuery();

            var nb = cmdesNbre.Value;
            //CA
            command = connection.CreateCommand();

            command.CommandText = "TotalClient";               //Associer Procédure Stockée
            command.CommandType = CommandType.StoredProcedure;
            paramCodeClient = new SqlParameter("@Code", codeClient);
            paramCodeClient.Direction = ParameterDirection.Input;
            command.Parameters.Add(paramCodeClient);

            var caMontant = new SqlParameter("RETURN_VALUE", SqlDbType.Decimal);
            caMontant.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(caMontant);

            command.ExecuteNonQuery();
            var ca = caMontant.Value;

            Console.WriteLine("Le client '{0}' a passé pour {1} commande(s) pour un montant de : {2} euros.", codeClient, nb, ca);

            Console.WriteLine("****************************************************");
            CloseConnection();
        }

    }
}
