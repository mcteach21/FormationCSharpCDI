using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsFormation
{
    public partial class Editeur : Form
    {
        public Editeur()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOuvrir = new OpenFileDialog();

            //Ce qui suit est facultatif - valeurs par défaut
            dlgOuvrir.Title = "Sélection du fichier à ouvrir..."; //Titre
            dlgOuvrir.InitialDirectory = Directory.GetCurrentDirectory() + "\\Documents";
            dlgOuvrir.Filter = "tous|*.*|Images|*.bmp;*.gif;*. jpg|texte|*.txt"; //Filtre fichiers
            dlgOuvrir.DefaultExt = "toto";
            dlgOuvrir.AddExtension = true;
        
            //Ligne ci-dessous indispensable
            dlgOuvrir.ShowDialog();

            if (dlgOuvrir.FileName != "")
            {
                richTextBox1.LoadFile(dlgOuvrir.FileName);
            }
            
            
            
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSauvegarder = new SaveFileDialog();

            //Ce qui suit est facultatif - valeurs par défaut
            dlgSauvegarder.Title = "Sélection du fichier à ouvrir..."; //Titre
            dlgSauvegarder.InitialDirectory = Directory.GetCurrentDirectory() + "\\Documents";
            dlgSauvegarder.Filter = "tous|*.*|Images|*.bmp;*.gif;*. jpg|texte|*.txt"; //Filtre fichiers
            dlgSauvegarder.DefaultExt = "toto";
            dlgSauvegarder.AddExtension = true;

            //Ligne ci-dessous indispensable
            dlgSauvegarder.ShowDialog();

            if (dlgSauvegarder.FileName != "")
            {
                richTextBox1.SaveFile(dlgSauvegarder.FileName);
            }
        }

        private void btnFormatText_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Verdana", (float)10, FontStyle.Bold | FontStyle.Italic); //Sera à la fois gras et italique
            richTextBox1.SelectionBackColor = Color.Aqua;
            richTextBox1.SelectionColor = Color.Bisque;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
