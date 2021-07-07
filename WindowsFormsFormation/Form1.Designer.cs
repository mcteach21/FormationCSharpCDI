namespace WindowsFormsFormation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMDI = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnDessin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDialogs = new System.Windows.Forms.Button();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnFolderDialog = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnPageSetupDialog = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnCustomDialog = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnHorloge = new System.Windows.Forms.Button();
            this.btnEditeur = new System.Windows.Forms.Button();
            this.btnListeCtrl = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blue = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backcolor (RGB) :";
            // 
            // btnMDI
            // 
            this.btnMDI.Location = new System.Drawing.Point(455, 29);
            this.btnMDI.Name = "btnMDI";
            this.btnMDI.Size = new System.Drawing.Size(150, 20);
            this.btnMDI.TabIndex = 5;
            this.btnMDI.Text = "Fenêtre &MDI...";
            this.btnMDI.UseVisualStyleBackColor = true;
            this.btnMDI.Click += new System.EventHandler(this.btnMDI_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Evénements clavier :";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(7, 286);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(948, 110);
            this.txtConsole.TabIndex = 8;
            this.txtConsole.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDessin
            // 
            this.btnDessin.Location = new System.Drawing.Point(455, 55);
            this.btnDessin.Name = "btnDessin";
            this.btnDessin.Size = new System.Drawing.Size(150, 20);
            this.btnDessin.TabIndex = 9;
            this.btnDessin.Text = "Dessin Souris...";
            this.btnDessin.UseVisualStyleBackColor = true;
            this.btnDessin.Click += new System.EventHandler(this.btnDessin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test Modal...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDialogs
            // 
            this.btnDialogs.Location = new System.Drawing.Point(455, 81);
            this.btnDialogs.Name = "btnDialogs";
            this.btnDialogs.Size = new System.Drawing.Size(150, 20);
            this.btnDialogs.TabIndex = 11;
            this.btnDialogs.Text = "Message Box...";
            this.btnDialogs.UseVisualStyleBackColor = true;
            this.btnDialogs.Click += new System.EventHandler(this.btnDialogs_Click);
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Location = new System.Drawing.Point(455, 107);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(150, 20);
            this.btnFileDialog.TabIndex = 12;
            this.btnFileDialog.Text = "Open File Dialog...";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(455, 133);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(150, 20);
            this.btnSaveFile.TabIndex = 13;
            this.btnSaveFile.Text = "Save File Dialog...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnFolderDialog
            // 
            this.btnFolderDialog.Location = new System.Drawing.Point(455, 159);
            this.btnFolderDialog.Name = "btnFolderDialog";
            this.btnFolderDialog.Size = new System.Drawing.Size(150, 20);
            this.btnFolderDialog.TabIndex = 14;
            this.btnFolderDialog.Text = "Folder Browser Dialog...";
            this.btnFolderDialog.UseVisualStyleBackColor = true;
            this.btnFolderDialog.Click += new System.EventHandler(this.btnFolderDialog_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(455, 185);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(150, 20);
            this.btnColorDialog.TabIndex = 15;
            this.btnColorDialog.Text = "Color Dialog...";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(455, 211);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(150, 20);
            this.btnFontDialog.TabIndex = 16;
            this.btnFontDialog.Text = "Font Dialog...";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnPageSetupDialog
            // 
            this.btnPageSetupDialog.Location = new System.Drawing.Point(455, 237);
            this.btnPageSetupDialog.Name = "btnPageSetupDialog";
            this.btnPageSetupDialog.Size = new System.Drawing.Size(150, 20);
            this.btnPageSetupDialog.TabIndex = 17;
            this.btnPageSetupDialog.Text = "Page Setup Dialog...";
            this.btnPageSetupDialog.UseVisualStyleBackColor = true;
            this.btnPageSetupDialog.Click += new System.EventHandler(this.btnPageSetupDialog_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(455, 263);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(150, 20);
            this.btnPrintDialog.TabIndex = 18;
            this.btnPrintDialog.Text = "Print Dialog...";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnCustomDialog
            // 
            this.btnCustomDialog.Location = new System.Drawing.Point(611, 30);
            this.btnCustomDialog.Name = "btnCustomDialog";
            this.btnCustomDialog.Size = new System.Drawing.Size(150, 20);
            this.btnCustomDialog.TabIndex = 19;
            this.btnCustomDialog.Text = "Custom Dialog...";
            this.btnCustomDialog.UseVisualStyleBackColor = true;
            this.btnCustomDialog.Click += new System.EventHandler(this.btnCustomDialog_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(156, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(137, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Ce texte va être remplacé...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(159, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnHorloge
            // 
            this.btnHorloge.Location = new System.Drawing.Point(611, 55);
            this.btnHorloge.Name = "btnHorloge";
            this.btnHorloge.Size = new System.Drawing.Size(150, 20);
            this.btnHorloge.TabIndex = 22;
            this.btnHorloge.Text = "Horloge (PgBar)...";
            this.btnHorloge.UseVisualStyleBackColor = true;
            this.btnHorloge.Click += new System.EventHandler(this.btnHorloge_Click);
            // 
            // btnEditeur
            // 
            this.btnEditeur.Location = new System.Drawing.Point(611, 81);
            this.btnEditeur.Name = "btnEditeur";
            this.btnEditeur.Size = new System.Drawing.Size(150, 20);
            this.btnEditeur.TabIndex = 23;
            this.btnEditeur.Text = "Editeur (RTxtBox)...";
            this.btnEditeur.UseVisualStyleBackColor = true;
            this.btnEditeur.Click += new System.EventHandler(this.btnEditeur_Click);
            // 
            // btnListeCtrl
            // 
            this.btnListeCtrl.Location = new System.Drawing.Point(805, 244);
            this.btnListeCtrl.Name = "btnListeCtrl";
            this.btnListeCtrl.Size = new System.Drawing.Size(150, 20);
            this.btnListeCtrl.TabIndex = 24;
            this.btnListeCtrl.Text = "Liste contrôles...";
            this.btnListeCtrl.UseVisualStyleBackColor = true;
            this.btnListeCtrl.Click += new System.EventHandler(this.btnListeCtrl_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fermerMenuItem,
            this.quitterMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(300, 44);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(80, 20);
            this.blue.TabIndex = 3;
            this.blue.Text = "0";
            this.blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(214, 44);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(80, 20);
            this.green.TabIndex = 2;
            this.green.Text = "0";
            this.green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.White;
            this.red.Location = new System.Drawing.Point(128, 44);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(80, 20);
            this.red.TabIndex = 1;
            this.red.Text = "0";
            this.red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnBackgroundColor.Location = new System.Drawing.Point(128, 71);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(252, 22);
            this.btnBackgroundColor.TabIndex = 4;
            this.btnBackgroundColor.Text = "Appliquer couleur";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideMenuItemToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.optionsToolStripMenuItem.Text = "Aide";
            // 
            // fermerMenuItem
            // 
            this.fermerMenuItem.Name = "fermerMenuItem";
            this.fermerMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fermerMenuItem.Text = "Fermer Fenêtre";
            this.fermerMenuItem.Click += new System.EventHandler(this.fermerMenuItem_Click);
            // 
            // quitterMenuItem
            // 
            this.quitterMenuItem.Name = "quitterMenuItem";
            this.quitterMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitterMenuItem.Text = "Quitter Application";
            this.quitterMenuItem.Click += new System.EventHandler(this.quitterMenuItem_Click);
            // 
            // aideMenuItemToolStripMenuItem
            // 
            this.aideMenuItemToolStripMenuItem.Name = "aideMenuItemToolStripMenuItem";
            this.aideMenuItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aideMenuItemToolStripMenuItem.Text = "Aide";
            this.aideMenuItemToolStripMenuItem.Click += new System.EventHandler(this.aideMenuItemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(961, 404);
            this.Controls.Add(this.btnListeCtrl);
            this.Controls.Add(this.btnEditeur);
            this.Controls.Add(this.btnHorloge);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCustomDialog);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnPageSetupDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.btnFolderDialog);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.btnDialogs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDessin);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMDI);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMDI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnDessin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDialogs;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnFolderDialog;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnPageSetupDialog;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnCustomDialog;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnHorloge;
        private System.Windows.Forms.Button btnEditeur;
        private System.Windows.Forms.Button btnListeCtrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem aideMenuItemToolStripMenuItem;
    }
}

