namespace WinFormsApp
{
    partial class AutreFenetre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutreFenetre));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFermerTout = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBarClose = new System.Windows.Forms.ProgressBar();
            this.menuFermerActive = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMissionImpossible = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFermerTout,
            this.menuFermerActive,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            this.fichierToolStripMenuItem.MouseLeave += new System.EventHandler(this.fichierToolStripMenuItem_MouseLeave);
            this.fichierToolStripMenuItem.MouseHover += new System.EventHandler(this.fichierToolStripMenuItem_MouseHover);
            // 
            // menuFermerTout
            // 
            this.menuFermerTout.Image = global::WinFormsApp.Properties.Resources.btn_fermer;
            this.menuFermerTout.Name = "menuFermerTout";
            this.menuFermerTout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.menuFermerTout.Size = new System.Drawing.Size(216, 26);
            this.menuFermerTout.Text = "Fermer T&out!";
            this.menuFermerTout.Click += new System.EventHandler(this.menuFermerTout_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.aProposToolStripMenuItem1.Text = "A propos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // pBarClose
            // 
            this.pBarClose.Location = new System.Drawing.Point(287, 4);
            this.pBarClose.Maximum = 20;
            this.pBarClose.Name = "pBarClose";
            this.pBarClose.Size = new System.Drawing.Size(250, 24);
            this.pBarClose.TabIndex = 2;
            this.pBarClose.Visible = false;
            // 
            // menuFermerActive
            // 
            this.menuFermerActive.Name = "menuFermerActive";
            this.menuFermerActive.Size = new System.Drawing.Size(216, 26);
            this.menuFermerActive.Text = "Fermer Courante";
            this.menuFermerActive.Click += new System.EventHandler(this.menuFermerActive_Click);
            // 
            // btnMissionImpossible
            // 
            this.btnMissionImpossible.Image = global::WinFormsApp.Properties.Resources.btn_fermer;
            this.btnMissionImpossible.Location = new System.Drawing.Point(493, 4);
            this.btnMissionImpossible.Name = "btnMissionImpossible";
            this.btnMissionImpossible.Size = new System.Drawing.Size(37, 23);
            this.btnMissionImpossible.TabIndex = 3;
            this.btnMissionImpossible.UseVisualStyleBackColor = true;
            this.btnMissionImpossible.Click += new System.EventHandler(this.btnMissionImpossible_Click);
            // 
            // AutreFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 502);
            this.Controls.Add(this.btnMissionImpossible);
            this.Controls.Add(this.pBarClose);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutreFenetre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autre Fenetre..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutreFenetre_FormClosing);
            this.Load += new System.EventHandler(this.AutreFenetre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFermerTout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pBarClose;
        private System.Windows.Forms.ToolStripMenuItem menuFermerActive;
        private System.Windows.Forms.Button btnMissionImpossible;
    }
}