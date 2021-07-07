namespace WinFormsApp
{
    partial class Principale
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
            this.components = new System.ComponentModel.Container();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMessageOuvrir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.ForeColor = System.Drawing.Color.Maroon;
            this.btnQuitter.Location = new System.Drawing.Point(73, 71);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(230, 35);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter!";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModal
            // 
            this.btnModal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModal.ForeColor = System.Drawing.Color.Lime;
            this.btnModal.Location = new System.Drawing.Point(73, 25);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(112, 40);
            this.btnModal.TabIndex = 1;
            this.btnModal.Text = "Ouvrir..";
            this.btnModal.UseVisualStyleBackColor = false;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuQuitter});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 30);
            // 
            // cmenuQuitter
            // 
            this.cmenuQuitter.Image = global::WinFormsApp.Properties.Resources.btn_fermer;
            this.cmenuQuitter.Name = "cmenuQuitter";
            this.cmenuQuitter.Size = new System.Drawing.Size(130, 26);
            this.cmenuQuitter.Text = "Quitter";
            this.cmenuQuitter.Click += new System.EventHandler(this.cmenuQuitter_Click);
            // 
            // btnMessageOuvrir
            // 
            this.btnMessageOuvrir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMessageOuvrir.ForeColor = System.Drawing.Color.Lime;
            this.btnMessageOuvrir.Location = new System.Drawing.Point(191, 25);
            this.btnMessageOuvrir.Name = "btnMessageOuvrir";
            this.btnMessageOuvrir.Size = new System.Drawing.Size(112, 40);
            this.btnMessageOuvrir.TabIndex = 2;
            this.btnMessageOuvrir.Text = "Ouvrir 2..";
            this.btnMessageOuvrir.UseVisualStyleBackColor = false;
            this.btnMessageOuvrir.Click += new System.EventHandler(this.btnMessageOuvrir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(73, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 126);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(73, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 126);
            this.panel2.TabIndex = 4;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 431);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMessageOuvrir);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre Principale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Principale_DoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmenuQuitter;
        private System.Windows.Forms.Button btnMessageOuvrir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

