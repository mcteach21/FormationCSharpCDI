using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFormation
{
    public partial class DessinSouris : Form
    {

        int rouge, vert, bleu;

        public DessinSouris()
        {
            InitializeComponent();

            txtRouge.MouseWheel += new MouseEventHandler(txtRouge_MouseWheel);
            txtVert.MouseWheel += new MouseEventHandler(txtVert_MouseWheel);
            txtBleu.MouseWheel += new MouseEventHandler(txtBleu_MouseWheel);
        }

        private void DessinSouris_Load(object sender, EventArgs e)
        {

        }

        private void DessinSouris_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g; //espace graphique : la fenêtre
            Pen crayon;
            if (e.Button == MouseButtons.Left)
            {
                g = Graphics.FromHwnd(this.Handle); //récupère l'espace graphique de la fenêtre à partir du pointeur
                Color couleur = Color.FromArgb((int)(rouge * 2.55), (int)(vert * 2.55), (int)(bleu * 2.55));
                crayon = new Pen(couleur);
                g.DrawEllipse(crayon, e.X, e.Y, 5, 5);  //Définit un rectangle
            }
        }

        void txtRouge_MouseWheel(object sender, MouseEventArgs e)
        {
            rouge += e.Delta / 120;
            if (rouge > 100)
            {
                rouge = 100;
            }
            else if (rouge < 0)
            {
                rouge = 0;
            }
            else
            {
                txtRouge.Text = rouge + "%";
            }

        }

        void txtVert_MouseWheel(object sender, MouseEventArgs e)
        {
            vert += e.Delta / 120;
            if (vert > 100)
            {
                vert = 100;
            }
            else if (vert < 0)
            {
                vert = 0;
            }
            else
            {
                txtVert.Text = vert + "%";
            }

        }

        void txtBleu_MouseWheel(object sender, MouseEventArgs e)
        {
            bleu += e.Delta / 120;
            if (bleu > 100)
            {
                bleu = 100;
            }
            else if (bleu < 0)
            {
                bleu = 0;
            }
            else
            {
                txtBleu.Text = bleu + "%";
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            bleu = 0;
            txtBleu.Text = bleu + "%";
            vert = 0;
            txtVert.Text = vert + "%";
            rouge = 0;
            txtRouge.Text = rouge + "%";
        }
    }
}
