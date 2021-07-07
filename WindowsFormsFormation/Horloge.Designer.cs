namespace WindowsFormsFormation
{
    partial class Horloge
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
            this.lblHeures = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSecondes = new System.Windows.Forms.Label();
            this.pgbHeure = new System.Windows.Forms.ProgressBar();
            this.pgbMinute = new System.Windows.Forms.ProgressBar();
            this.pgbSeconde = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnContinuous = new System.Windows.Forms.Button();
            this.btnBlocks = new System.Windows.Forms.Button();
            this.btnMarquee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeures
            // 
            this.lblHeures.AutoSize = true;
            this.lblHeures.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeures.Location = new System.Drawing.Point(30, 55);
            this.lblHeures.Name = "lblHeures";
            this.lblHeures.Size = new System.Drawing.Size(50, 22);
            this.lblHeures.TabIndex = 0;
            this.lblHeures.Text = "Heures";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(21, 91);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(59, 22);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblSecondes
            // 
            this.lblSecondes.AutoSize = true;
            this.lblSecondes.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondes.Location = new System.Drawing.Point(17, 123);
            this.lblSecondes.Name = "lblSecondes";
            this.lblSecondes.Size = new System.Drawing.Size(63, 22);
            this.lblSecondes.TabIndex = 2;
            this.lblSecondes.Text = "Secondes";
            // 
            // pgbHeure
            // 
            this.pgbHeure.Location = new System.Drawing.Point(104, 55);
            this.pgbHeure.Name = "pgbHeure";
            this.pgbHeure.Size = new System.Drawing.Size(431, 17);
            this.pgbHeure.TabIndex = 3;
            // 
            // pgbMinute
            // 
            this.pgbMinute.Location = new System.Drawing.Point(104, 91);
            this.pgbMinute.Name = "pgbMinute";
            this.pgbMinute.Size = new System.Drawing.Size(431, 16);
            this.pgbMinute.TabIndex = 4;
            // 
            // pgbSeconde
            // 
            this.pgbSeconde.Location = new System.Drawing.Point(104, 123);
            this.pgbSeconde.Name = "pgbSeconde";
            this.pgbSeconde.Size = new System.Drawing.Size(431, 16);
            this.pgbSeconde.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnContinuous
            // 
            this.btnContinuous.Location = new System.Drawing.Point(581, 49);
            this.btnContinuous.Name = "btnContinuous";
            this.btnContinuous.Size = new System.Drawing.Size(75, 23);
            this.btnContinuous.TabIndex = 6;
            this.btnContinuous.Text = "Continuous";
            this.btnContinuous.UseVisualStyleBackColor = true;
            this.btnContinuous.Click += new System.EventHandler(this.btnContinuous_Click);
            // 
            // btnBlocks
            // 
            this.btnBlocks.Location = new System.Drawing.Point(581, 84);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(75, 23);
            this.btnBlocks.TabIndex = 7;
            this.btnBlocks.Text = "Blocks";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnBlocks_Click);
            // 
            // btnMarquee
            // 
            this.btnMarquee.Location = new System.Drawing.Point(581, 116);
            this.btnMarquee.Name = "btnMarquee";
            this.btnMarquee.Size = new System.Drawing.Size(75, 23);
            this.btnMarquee.TabIndex = 8;
            this.btnMarquee.Text = "Marquee";
            this.btnMarquee.UseVisualStyleBackColor = true;
            this.btnMarquee.Click += new System.EventHandler(this.btnMarquee_Click);
            // 
            // Horloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 198);
            this.Controls.Add(this.btnMarquee);
            this.Controls.Add(this.btnBlocks);
            this.Controls.Add(this.btnContinuous);
            this.Controls.Add(this.pgbSeconde);
            this.Controls.Add(this.pgbMinute);
            this.Controls.Add(this.pgbHeure);
            this.Controls.Add(this.lblSecondes);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHeures);
            this.Name = "Horloge";
            this.Text = "Horloge";
            this.Load += new System.EventHandler(this.Horloge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeures;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSecondes;
        private System.Windows.Forms.ProgressBar pgbHeure;
        private System.Windows.Forms.ProgressBar pgbMinute;
        private System.Windows.Forms.ProgressBar pgbSeconde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnContinuous;
        private System.Windows.Forms.Button btnBlocks;
        private System.Windows.Forms.Button btnMarquee;
    }
}