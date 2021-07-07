using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AutreFenetre : Form
    {
        Form fenetre_owner; //Fenetre Appelante!
        Thread tClose;
        private delegate void ChangeProgressBarDelegate();
        private void ChangeProgressBar(){
            pBarClose.Value++; // augmenter valeur progress bar
            if(pBarClose.Value == pBarClose.Maximum)
            {
                this.Close(); //Fermer Fenêtre Courante.
            }
        }

       
        public AutreFenetre()
        {
            InitializeComponent();

            tClose = new Thread(closeOp);       
        }

        private void closeOp()
        {
            int i = 1;
            while (i <= 20)
            {
                this.Invoke(new ChangeProgressBarDelegate(ChangeProgressBar));
                i++;
                Thread.Sleep(500);
            }
        }

        private void AutreFenetre_Load(object sender, EventArgs e)
        {
            
            //Recup Fenêtre Propriétaire (owner)!!
           fenetre_owner = this.Owner;

            //Créer Fenetres 'Filles'..
            Color[] colors = new Color[] { Color.AliceBlue, Color.Red, Color.SaddleBrown};
            FenetreFille f;
            for (int i = 0; i < 3; i++)
            {
                f = new FenetreFille();
                f.Name = "fenetre_" + i;
                f.Text = "Fenêtre.." + (i+1);
                f.BackColor = colors[i];

                f.MdiParent = this;

                f.Show();
            }

            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void AutreFenetre_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Rendre visible fenetre 'Principale'(=owner!)
            fenetre_owner.Visible = true;
        }

        private void menuFermerTout_Click(object sender, EventArgs e)
        {
            //MdiChildren : ensemble des fenetres 'filles'!
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fichierToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            fichierToolStripMenuItem.ForeColor = Color.Red;
        }

        private void fichierToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            fichierToolStripMenuItem.ForeColor = Color.WhiteSmoke;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuFermerActive_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)
                this.ActiveMdiChild.Close();
        }

        private void btnMissionImpossible_Click(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            pBarClose.Visible = true;
            tClose.Start();
        }
    }
}
