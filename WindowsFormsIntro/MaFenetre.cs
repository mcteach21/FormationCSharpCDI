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
    public partial class MaFenetre : Form
    {
        public MaFenetre()
        {
            InitializeComponent();

            timer1.Enabled = true;
        }

        private void MaFenetre_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chargement de ma Fenêtre!");
            btnDialogCustom.BackgroundImage = new Bitmap("img/fond.jpg");
            btnDialogCustom.ForeColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AutreFenetre f= new AutreFenetre();
            f.ShowDialog(this);
        }

        private void MaFenetre_Move(object sender, EventArgs e)
        {
            txtX.Text = ""+this.Location.X;
            txtY.Text = this.Location.Y.ToString();

            //Console.WriteLine(this.Size.Width + " " + this.Size.Height);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(150, 100, 255);
            //this.Font = new Font(FontFamily.GenericSerif, 12.0f);
        }

        private void btnOpenMDI_Click(object sender, EventArgs e)
        {
            FenetreMDI mdi = new FenetreMDI();
            mdi.Show();
        }

        private void txtKeys_KeyDown(object sender, KeyEventArgs e)
        {
            txtConsole.Text += "Event. KeyDown : " + e.KeyCode + " " + e.KeyValue+"\r\n";
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOuvrir = new OpenFileDialog();

            dlgOuvrir.Title = "selection du f ichier à ouvrir"; //Titre
            dlgOuvrir.Filter = "tous|*.*|Images|*.bmp;*.gif;*. jpg|texte|*.txt"; //Filtre f ichiers
            dlgOuvrir.DefaultExt = "toto";
            dlgOuvrir.AddExtension = true;
            dlgOuvrir.CheckFileExists = false;
            dlgOuvrir.Multiselect = true;

            dlgOuvrir.ShowDialog();

            String[] files= dlgOuvrir.FileNames;
            foreach (var file in files)
            {
                MessageBox.Show(file);
            }
        }

        private void MaFenetre_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
                "Etes-vous sûr de vouloir quitter?" //message
                , "Fin du programme" //titre
                , MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );
            if (reponse == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
             //   MessageBox.Show("Bye!");
            }
        }

        private void btnDialogCustom_Click(object sender, EventArgs e)
        {
            DialogResult result= new CustomDialog().ShowDialog();
            MessageBox.Show(result.ToString());
        }

        private void btnValiderSaisie_Click(object sender, EventArgs e)
        {
            if (txtKeys.Text.Equals(""))
            {
                errorProvider1.SetError(txtKeys, "Champ Obligatoire!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbarSec.Value = DateTime.Now.Second;
        }
    }
}
