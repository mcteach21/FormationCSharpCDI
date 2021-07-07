namespace WindowsFormsFormation
{
    partial class DessinSouris
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
            this.txtRouge = new System.Windows.Forms.TextBox();
            this.txtVert = new System.Windows.Forms.TextBox();
            this.txtBleu = new System.Windows.Forms.TextBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRouge
            // 
            this.txtRouge.BackColor = System.Drawing.Color.Red;
            this.txtRouge.Location = new System.Drawing.Point(330, 381);
            this.txtRouge.Name = "txtRouge";
            this.txtRouge.Size = new System.Drawing.Size(100, 20);
            this.txtRouge.TabIndex = 0;
            this.txtRouge.Text = "0%";
            this.txtRouge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVert
            // 
            this.txtVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtVert.Location = new System.Drawing.Point(445, 381);
            this.txtVert.Name = "txtVert";
            this.txtVert.Size = new System.Drawing.Size(100, 20);
            this.txtVert.TabIndex = 1;
            this.txtVert.Text = "0%";
            this.txtVert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBleu
            // 
            this.txtBleu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtBleu.Location = new System.Drawing.Point(560, 381);
            this.txtBleu.Name = "txtBleu";
            this.txtBleu.Size = new System.Drawing.Size(100, 20);
            this.txtBleu.TabIndex = 2;
            this.txtBleu.Text = "0%";
            this.txtBleu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(867, 17);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(68, 32);
            this.btnEffacer.TabIndex = 3;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(681, 381);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(129, 19);
            this.btnInitialiser.TabIndex = 4;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // DessinSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 413);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.txtBleu);
            this.Controls.Add(this.txtVert);
            this.Controls.Add(this.txtRouge);
            this.Name = "DessinSouris";
            this.Text = "DessinSouris";
            this.Load += new System.EventHandler(this.DessinSouris_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DessinSouris_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRouge;
        private System.Windows.Forms.TextBox txtVert;
        private System.Windows.Forms.TextBox txtBleu;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnInitialiser;
    }
}