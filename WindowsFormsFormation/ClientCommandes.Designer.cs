namespace WindowsFormsFormation
{
    partial class ClientCommandes
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
            this.grilleClients = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.currentClient = new System.Windows.Forms.Label();
            this.grilleCdes = new System.Windows.Forms.DataGridView();
            this.lblCommandes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleCdes)).BeginInit();
            this.SuspendLayout();
            // 
            // grilleClients
            // 
            this.grilleClients.AllowUserToAddRows = false;
            this.grilleClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleClients.Location = new System.Drawing.Point(13, 41);
            this.grilleClients.Name = "grilleClients";
            this.grilleClients.Size = new System.Drawing.Size(950, 210);
            this.grilleClients.TabIndex = 0;
            this.grilleClients.SelectionChanged += new System.EventHandler(this.grilleClients_SelectionChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Charger Données";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Sauvegarder Données";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // currentClient
            // 
            this.currentClient.AutoSize = true;
            this.currentClient.Location = new System.Drawing.Point(12, 407);
            this.currentClient.Name = "currentClient";
            this.currentClient.Size = new System.Drawing.Size(10, 13);
            this.currentClient.TabIndex = 3;
            this.currentClient.Text = ".";
            // 
            // grilleCdes
            // 
            this.grilleCdes.AllowUserToAddRows = false;
            this.grilleCdes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleCdes.Location = new System.Drawing.Point(15, 270);
            this.grilleCdes.Name = "grilleCdes";
            this.grilleCdes.Size = new System.Drawing.Size(950, 157);
            this.grilleCdes.TabIndex = 4;
            // 
            // lblCommandes
            // 
            this.lblCommandes.AutoSize = true;
            this.lblCommandes.Location = new System.Drawing.Point(12, 254);
            this.lblCommandes.Name = "lblCommandes";
            this.lblCommandes.Size = new System.Drawing.Size(90, 13);
            this.lblCommandes.TabIndex = 5;
            this.lblCommandes.Text = "Liste Commandes";
            // 
            // ClientCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 439);
            this.Controls.Add(this.lblCommandes);
            this.Controls.Add(this.grilleCdes);
            this.Controls.Add(this.currentClient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grilleClients);
            this.Name = "ClientCommandes";
            this.Text = "ClientCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleCdes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilleClients;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label currentClient;
        private System.Windows.Forms.DataGridView grilleCdes;
        private System.Windows.Forms.Label lblCommandes;
    }
}