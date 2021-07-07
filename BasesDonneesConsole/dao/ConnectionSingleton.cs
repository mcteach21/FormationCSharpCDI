using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesDonneesConsole.dao
{
    public class ConnectionSingleton
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["NorthwindSqlConnection"].ConnectionString;
        static SqlConnection connection = null;

        private static ConnectionSingleton instance;
        private ConnectionSingleton()
        {

        }
        public static ConnectionSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnectionSingleton();
                    Console.WriteLine("=========>Création Instance Connection!!!!!!!!");
                }
                return instance;
            }
        }
    }
}
