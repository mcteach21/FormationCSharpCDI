using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;  //Pour pouvoir utiliser le StreamWriter                  
using System.Drawing.Printing;     //Pour pour utiliser PageSettings
       
    
namespace WindowsFormsFormation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //Ne rien mettre avant... Création du formulaire
        }

        private void Form1_Load(object sender, EventArgs e) //Au chargement du formulaire
        {
            lblEmail.Text = "Je teste les labels...";
            lblEmail.AutoSize = true;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;

        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)   //Au clic sur le bouton, on applique les RGB
        {
            this.BackColor = Color.FromArgb(int.Parse(red.Text), int.Parse(green.Text), int.Parse(blue.Text));  //Parse convertit le string en int

        }

        private void btnMDI_Click(object sender, EventArgs e)
        {
            new FenetresMDI().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)    //On tape dans textBox1 et on affiche dans txtConsole
        {
            txtConsole.Clear();
            txtConsole.Text = "KeyDown = " + e.KeyCode + " " + e.KeyValue + " " + e.KeyData;
            if (e.Alt && (e.KeyCode == Keys.A))        //Si on tape sur la touche A et Alt en même temps
            {
                textBox1.Text += "-->"+textBox1.Text.ToLower();    //on écrit en minuscules dans textBox1 avec une flèche devant
                //+= fait une concaténation : a +=b équivaut à a=a+b
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            txtConsole.Text += "\r\nKeyUp = " + e.KeyCode + " " + e.KeyValue + " " + e.KeyData;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConsole.Text += "\r\nKeyPress = " + e.KeyChar + " " + e.Handled;
            if (e.KeyChar.ToString().Equals("x")) e.Handled = true;             //Ne pas afficher le caractère x

            bool resultat; int i;
            resultat=int.TryParse((e.KeyChar.ToString()),out i);    //Tous les caractères alphabétiques
            if (!resultat)
            {
                SystemSounds.Beep.Play();       //using System.Media
                e.Handled=true;     //Le caractère ne s'affiche pas dans txtBox1
                txtConsole.Text += "\r\n" + e.KeyChar.ToString() + " : caractère non permis !";
            }
        }

        private void btnDessin_Click(object sender, EventArgs e)
        {
            new DessinSouris().Show();  //ouvrir une nouvelle fenêtre DessinSouris
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new FormModalTests().ShowDialog();    //Affiche FormModalTests puis, quand on ferme cette fenêtre, affiche la MessageBox
            //MessageBox.Show("C'est fermé ?");

            new FormModalTests().Show();            //Affiche FormModalTests et en même temps affiche la MessageBox
            MessageBox.Show("C'est fermé ?");
        }

        private void btnDialogs_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show(
                "Voulez-vous enregistrer en quittant l'application ?" //message
                , "Fin du programme"    //message
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1    //options  boutons
            );

            switch (reponse)
            {
                case DialogResult.Yes:
                    //Bouton Oui
                    MessageBox.Show("Bouton 'Oui'");
                    break;
                case DialogResult.No :
                    //Bouton Non
                    MessageBox.Show("Bouton 'Non'");
                    break;
                case DialogResult.Cancel:
                    //Bouton Annuler
                    MessageBox.Show("Bouton 'Annuler'");
                    break;
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOuvrir = new OpenFileDialog();

            //Ce qui suit est facultatif - valeurs par défaut
            dlgOuvrir.Title = "Sélection du fichier à ouvrir..."; //Titre
            dlgOuvrir.Filter = "tous|*.*|Images|*.bmp;*.gif;*. jpg|texte|*.txt"; //Filtre fichiers
            dlgOuvrir.DefaultExt = "toto";
            dlgOuvrir.AddExtension = true;
            dlgOuvrir.CheckFileExists = false;  //ne teste pas si le fichier existe
            dlgOuvrir.Multiselect = true;
            dlgOuvrir.InitialDirectory="C:\\";
            //autre écriture : @"C:\";    @ considère que tous les caractères suivants sont normaux

            //Ligne ci-dessous indispensable
            dlgOuvrir.ShowDialog();

            foreach (String nomFichier in dlgOuvrir.FileNames)      //FileNames au pluriel
            {
                MessageBox.Show(nomFichier);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();

            dlgSave.Title = "Sauvegardez Fichier..."; //Titre
            dlgSave.Filter = "tous|*.*|texte|*.txt";
            dlgSave.InitialDirectory = "C:\\";
            dlgSave.OverwritePrompt = true;

            DialogResult result = dlgSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                String savefile = dlgSave.FileName;
                using (StreamWriter sw = new StreamWriter(savefile))
                {
                    sw.WriteLine("Hello world ! " + DateTime.Now);      //C'est ce qui s'écrit dans le fichier sauvegardé
                }
            }

           
        }

        private void btnFolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgChoixRep = new FolderBrowserDialog();
            dlgChoixRep.RootFolder = Environment.SpecialFolder.MyDocuments;
            DialogResult result = dlgChoixRep.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show(dlgChoixRep.SelectedPath, "Répertoire sélectionné");
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true; // affichage controle utilisation des couleurs personnalisées
            dlgColor.Color = this.BackColor;

            DialogResult result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = dlgColor.Color;        //Change couleur du formulaire
                //this.btnColorDialog.BackColor = dlgColor.Color;   //Change couleur du bouton
            }
        }


        FontDialog dlgFont;

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            dlgFont = new FontDialog();
            dlgFont.ShowApply = true;
            dlgFont.ShowColor = true;
            dlgFont.ShowEffects = true;
            dlgFont.MaxSize = 20;
            dlgFont.MinSize = 12;
            dlgFont.FontMustExist = true;
            dlgFont.Apply += new EventHandler(dlgFont_Apply);       //Crée un nouvel événement
            dlgFont.ShowDialog();
            label1.Font = dlgFont.Font;     //Modifie la police de notre Label1
        }

        void dlgFont_Apply(object sender, EventArgs e)      //Définition du nouvel événement créé ci-dessus
        {
            MessageBox.Show("Font appliquée : " + dlgFont.Font.Name);
        }

        private void btnPageSetupDialog_Click(object sender, EventArgs e)
        {
            PageSetupDialog dlgPgSetup = new PageSetupDialog();
            PageSettings configPg = new PageSettings();
            PrinterSettings configPrt = new PrinterSettings();
            dlgPgSetup.PageSettings = configPg;
            dlgPgSetup.AllowPrinter = true;
            dlgPgSetup.PrinterSettings = configPrt;
            dlgPgSetup.ShowDialog();

            MessageBox.Show("vous avez choisi d'imprimer avec l'imprimante " +
            dlgPgSetup.PrinterSettings.PrinterName + " sur du papier " +
            dlgPgSetup.PageSettings.PaperSize.PaperName + " en format " +
            ((dlgPgSetup.PageSettings.Landscape ? "paysage" : "portrait")));    //condition : si vrai, on prend paysage, sinon portrait
                                                                                //équivalent du if/else pour récupérer une valeur en return
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            PrinterSettings configPrt = new PrinterSettings();
            PrintDialog dlgprinter = new PrintDialog();
            dlgprinter.PrinterSettings = configPrt;
            dlgprinter.AllowSomePages = true;
            dlgprinter.AllowSelection = true;
            dlgprinter.ShowDialog();

            switch (dlgprinter.PrinterSettings.PrintRange)
            {
                case PrintRange.AllPages:
                    MessageBox.Show("vous avez demandé l'impression de tout le document"); break;
                case PrintRange.SomePages:
                    MessageBox.Show("vous avez demandé l'impression de la page " +
                    dlgprinter.PrinterSettings.FromPage + " à la page " + dlgprinter.PrinterSettings.ToPage);
                    break;
                case PrintRange.Selection:
                    MessageBox.Show("vous avez demandé l'impression de la sélection"); break;
            }
        }

        private void btnCustomDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = new MaBoiteDialogue().ShowDialog();
            MessageBox.Show("Bouton cliqué : " + result);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.fr");
            linkLabel1.LinkVisited = true;

        }

        private void btnHorloge_Click(object sender, EventArgs e)
        {
            DialogResult result = new Horloge().ShowDialog();
        }

        private void btnEditeur_Click(object sender, EventArgs e)
        {
            DialogResult result = new Editeur().ShowDialog();
        }

        private void btnListeCtrl_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    txtConsole.Text += "\r\n Button : " + (ctrl as Button).Name;
                }
                if (ctrl is TextBox)
                {
                    txtConsole.Text += "\r\n TextBox : " + (ctrl as TextBox).Name;
                    //txtConsole.Text += "\r\n TextBox : " + ctrl.Name;     // est équivalent à la ligne précédente
                }

            }
        }

        private void fermerMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   //fermeture du Form
        }

        private void quitterMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fermeture de toute l'application
        }

        private void aideMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aide en cours de rédaction...");
        }





       
    }
}
