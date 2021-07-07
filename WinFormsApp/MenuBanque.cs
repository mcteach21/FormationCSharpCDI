using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuBanque : Form
    {
        public MenuBanque()
        {
            InitializeComponent();
        }

        private void menuQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Etes-vous sûr?", 
                "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }            
        }
    }
}
