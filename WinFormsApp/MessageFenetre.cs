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
    public partial class MessageFenetre : Form
    {
        public MessageFenetre()
        {
            InitializeComponent();
        }
        public MessageFenetre(string message):this()
        {
            lblMessage.Text = message;
        }

        private void MessageFenetre_Load(object sender, EventArgs e)
        {

        }
    }
}
