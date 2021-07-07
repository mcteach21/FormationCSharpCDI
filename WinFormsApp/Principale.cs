using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Principale : Form
    {
        public Principale()
        {
            //Méthode du designer pour 'dessin' Fenêtre..
            //..Toujours en premier!!!
            InitializeComponent();

            //..code autre
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chargement Fenêtre!");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Fermer Fenêtre courante (this) de type 'Form1'!!
            this.Close();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            AutreFenetre fen = new AutreFenetre();
            this.Visible = false;
            fen.Show(this);
        }

        private void cmenuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMessageOuvrir_Click(object sender, EventArgs e)
        {
            string message = "Il fait bo aujourd'hui!";
            MessageFenetre fen = new MessageFenetre(message);

            // Si propriété 'Modifiers' de lblMessage = public 
            //fen.lblMessage.Text = message;
            fen.Show();
        }

        private void Principale_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Height = 0;
        }
    }
}
