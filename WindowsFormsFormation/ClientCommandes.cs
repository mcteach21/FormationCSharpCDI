using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsFormation
{
    public partial class ClientCommandes : Form
    {
        const String cs = "Data Source=AFIP-B6;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=afipafip";
        SqlCommand cmd;
        SqlConnection ctn;
        DataSet ds;
        SqlDataAdapter da1,da2;

        public ClientCommandes()
        {
            InitializeComponent();
            ctn=new SqlConnection(cs);
            ds = new DataSet();
            da1 = new SqlDataAdapter(); //DataAdapter pour Clients
            da2 = new SqlDataAdapter(); //DataAdapter pour Commandes

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Charger Liste clients + afficher dans la grille 
            
            if (ds.Tables.Contains("Clients"))
            {
                ds.Tables["Clients"].Clear();   //Pour pouvoir appuyer plusieurs fois sur le bouton, on efface la DS
            }
            cmd = new SqlCommand("SELECT * FROM Customers", ctn);
            da1.SelectCommand = cmd;
            da1.Fill(ds, "Clients");  //remplissage de la copie en local de la BDD
                
            grilleClients.DataSource = ds.Tables["Clients"];    //Pour définir la source des données de la grille
            grilleClients.Refresh();
        }

        private void grilleClients_SelectionChanged(object sender, EventArgs e)
        {
            if (grilleClients.CurrentRow != null)
            {
                currentClient.Text = grilleClients.CurrentRow.Cells[0].Value.ToString();    //Récupère les infos de la ligne courante dans le Label currentClient
                string codeClient = currentClient.Text;
                charger_commandes(codeClient);
            }
        }

        private void charger_commandes(string codeClient)
        {
            if (ds.Tables.Contains("Commandes"))
            {
                ds.Tables["Commandes"].Clear();
            }

            try
            {
                cmd = new SqlCommand("SELECT * FROM Orders WHERE CustomerID=@Code", ctn);
                SqlParameter paramCodeClient = new SqlParameter("@Code", codeClient);
                cmd.Parameters.Add(paramCodeClient);
                da2 = new SqlDataAdapter(cmd);
                da2.Fill(ds, "Commandes");

                grilleCdes.DataSource = ds.Tables["Commandes"];
                grilleCdes.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder bld2 = new SqlCommandBuilder(da2);    //D'abord on modifie dans Commandes
            da2.Update(ds.Tables["Commandes"]);
            grilleCdes.Refresh();

            SqlCommandBuilder bld1 = new SqlCommandBuilder(da1);    //Ensuite on modifie dans Clients
            da1.Update(ds.Tables["Clients"]);
            grilleClients.Refresh();

            

        }

        
        
    }
}
