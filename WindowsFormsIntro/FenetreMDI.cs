using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsIntro
{
    public partial class FenetreMDI : Form
    {
        public FenetreMDI()
        {
            InitializeComponent();

            menucontextItemQuitter.Click += menucontextItemQuitter_Click;
        }

        void menucontextItemQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form fenetre1, fenetre2, fenetre3;
        private void FenetreMDI_Load(object sender, EventArgs e)
        {
            
            fenetre1 = new Form(); fenetre1.Text = "fenetre 1"; fenetre1.MdiParent = this; fenetre1.Show();
            fenetre2 = new Form(); fenetre2.Text = "fenetre 2"; fenetre2.MdiParent = this; fenetre2.Show();
            fenetre3 = new Form(); fenetre3.Text = "fenetre 3"; fenetre3.MdiParent = this; fenetre3.Show();
        }

        private void menuItemFermer_Click(object sender, EventArgs e)
        {
            //fenetre1.Close();
            //fenetre2.Close();
            //fenetre3.Close();

            foreach (var fen in this.MdiChildren)
            {
                fen.Close(); 
            }
        }
    }
}
