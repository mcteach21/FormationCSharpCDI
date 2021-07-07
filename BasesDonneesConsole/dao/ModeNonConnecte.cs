using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BasesDonneesConsole.dao
{
    public class ModeNonConnecte
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["NorthwindSqlConnection"].ConnectionString;
        SqlDataAdapter adapter;
        DataSet dataset;
        
        public void DataSetUpdateDB()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** DataSet Update BD!*******************");

            //1 : Remplir DataSet à partir de BD!
            dataset = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM Categories;", connectionString);
            adapter.Fill(dataset, "Catégories");

            //2 : Modifier Dataset   
            DataTable table = dataset.Tables["Catégories"];
            DataRow ligne;
            for (int i = 0; i < 2; i++)
            {
                ligne = dataset.Tables["Catégories"].NewRow();
                ligne["CategoryName"] = "Formation C#!"+i;
                ligne["Description"] = "Formation CSharp CDI..";

                table.Rows.Add(ligne);
            }
                                
            table.Rows[0]["CategoryName"] = table.Rows[0]["CategoryName"] + "!";
            table.Rows[table.Rows.Count-2].Delete();

            //3 : Mise à jour BD! 
            DataRow[] lignes;

            //Génération Auto. des requetes de Delete, Update et Insert
            SqlCommandBuilder bldr = new SqlCommandBuilder(adapter);

            Console.WriteLine("Instruction SQL de UpadteCommand : {0}", bldr.GetUpdateCommand().CommandText);
            Console.WriteLine("Instruction SQL de InsertCommand : {0}", bldr.GetInsertCommand().CommandText);
            Console.WriteLine("Instruction SQL de DeleteCommand : {0}", bldr.GetDeleteCommand().CommandText);
            
            // recupere les lignes supprimées et demande la mise à jour de la base
            lignes = table.Select(null, null, DataViewRowState.Deleted);
            //Console.WriteLine("Nb. lignes supprimées : {0}",lignes.Length);
            adapter.Update(lignes);

            // recupere les lignes modifiées et demande la mise à jour de la base
            lignes = table.Select(null, null, DataViewRowState.ModifiedCurrent);
            //Console.WriteLine("Nb. lignes modifiées : {0}", lignes.Length);
            adapter.Update(lignes);

            // recupere les lignes ajoutées et demande la mise à jour de la base
            lignes = table.Select(null, null, DataViewRowState.Added);
            //Console.WriteLine("Nb. lignes ajoutées : {0}", lignes.Length);
            adapter.Update(lignes);

            //Console.WriteLine("******************************************");
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    Console.WriteLine("{0} {1} - {2} ", row["CategoryID"],  row["CategoryName"], row.RowState);
                else
                    Console.WriteLine("Ligne Supprimée!!!");
            }
            //Console.WriteLine("dataset.AcceptChanges()..");

            ////Valider Modifications sur DataSet!!!
            //dataset.AcceptChanges();

            //foreach (DataRow row in table.Rows)
            //{
            //    Console.WriteLine("{0} - {1} ",row["CategoryName"], row.RowState);
            //}
            //Console.WriteLine("******************************************");

            Console.WriteLine("****************************************************");
        }
        public void RemplirDataSetNoDB()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** DataSet Sans BD! ********************");
            DataTable table = new DataTable("Commandes");

            DataColumn col = new DataColumn("Ht", Type.GetType("System.Decimal"));
            table.Columns.Add(col);
            //table.Columns.Add("Ht", Type.GetType("System.Decimal"));
            table.Columns.Add("Tva", Type.GetType("System.Decimal"));
            table.Columns.Add("Ttc", Type.GetType("System.Decimal"), "Ht * (1 + Tva / 100)");

            col = new DataColumn("ID", Type.GetType("System.Int32"));
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1000;
            col.AutoIncrementStep = 10;
            table.Columns.Add(col);

            table.PrimaryKey = new DataColumn[] { col }; //Définition Clé(s) Primaire(s)!

            //ajout ligne(s)
            DataRow row;
            for (int i = 1; i <= 5; i++)
            {
                row = table.NewRow();
                row["Ht"] = 150.25*i;
                row["Tva"] = 5.5*i/2;
                table.Rows.Add(row);
            }

            dataset = new DataSet("DatasetNoDB");
            dataset.Tables.Add(table);

            //foreach (DataColumn dc in dataset.Tables["Commandes"].Columns)
            //    Console.Write(dc.ColumnName + "\t");
            //Console.WriteLine();
            foreach (DataRow ligne in dataset.Tables["Commandes"].Rows)
            {
                Console.WriteLine("{0} - \t {1}\t{2} \t TTC = {3}", ligne["ID"], ligne["Ht"], ligne["Tva"], ligne["Ttc"]);
            }
            Console.WriteLine("****************************************************");
        }
        public void Remplir2DataSet()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** Remplir un DataSet 2 ****************");
                       
            var selectCommand = "SELECT * FROM Customers;";           
            adapter = new SqlDataAdapter(selectCommand, connectionString);

            dataset = new DataSet();

            //adapter.FillSchema(dataset, SchemaType.Mapped, "Clients");
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dataset, "Clients");

            DataTable table = dataset.Tables["Clients"];
            try
            {
               DataRow row_new = table.NewRow();
               row_new["CustomerID"] = "ALFKI";
               row_new["CompanyName"] = "xxxx";
               table.Rows.Add(row_new);
            }
            catch (Exception e)
            {
               Console.WriteLine("Ajout Ligne Impossible! : "+e.Message);
            }
            foreach (DataRow ligne in table.Rows)
            {
               Console.WriteLine(ligne["CustomerID"]);
            }
            Console.WriteLine("****************************************************");
        }
        public void RemplirDataSet()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************** Remplir un DataSet ******************");

            //1 : création objet 'SqlDataAdapter'
            var selectCommand = "SELECT * FROM Categories;";
            adapter = new SqlDataAdapter(selectCommand, connectionString);
            //2: remplir DataSet
            dataset = new DataSet();

            //Ajout Mapping Table - DataTable
            DataTableMapping mappage = new DataTableMapping("Categories", "Catégories");

            mappage.ColumnMappings.Add("CategoryID", "ID");
            mappage.ColumnMappings.Add("CategoryName", "Nom Catégorie");
            adapter.TableMappings.Add(mappage);
            
            //remplir (struct+data) dataset (image BD locale) avec résultat requete associée à 'selectCommand'!
            adapter.Fill(dataset, "Categories"); //Saisir nom table pour appliquer Mapping!!!

            DataTable table = dataset.Tables["Catégories"];  //dataset.Tables[0];
            Console.WriteLine(table.TableName+" "+table.Rows.Count);
            foreach (DataColumn col in table.Columns)
            {
                if(!col.ColumnName.Equals("Picture"))
                    Console.Write(col.ColumnName+"\t\t");
            }
            Console.WriteLine(); Console.WriteLine("============================================================");
            foreach (DataRow row in table.Rows)
            {
                //for (int i = 0; i < table.Columns.Count; i++)
                //{
                //    Console.Write(row.ItemArray[i]+"\t|");
                //}
                foreach (DataColumn col in table.Columns)
                {
                    if (!col.ColumnName.Equals("Picture"))
                        Console.Write(row[col] + "\t\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************");
        }
    }
}
