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
    public partial class AutreFenetre : Form
    {
        public AutreFenetre()
        {
            InitializeComponent();
        }

        private void AutreFenetre_Load(object sender, EventArgs e)
        {
           
        }

        private void AutreFenetre_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
