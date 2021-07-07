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
    public partial class FenetresMDI : Form
    {
        public FenetresMDI()
        {
            InitializeComponent();
            Form fenetre1, fenetre2, fenetre3;
            fenetre1 = new Form();
            fenetre1.Text = "fenetre1";
            fenetre1.MdiParent = this;
            fenetre1.Show();
            fenetre2 = new Form();
            fenetre2.Text = "fenetre2";
            fenetre2.MdiParent = this;
            fenetre2.Show();
            fenetre3 = new FormFenetre();
            fenetre3.Text = "fenetre3";
            fenetre3.MdiParent = this;
            fenetre3.Show();

            
        }

        private void FenetresMDI_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
