namespace WindowsFormsFormation
{
    partial class Editeur
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnFormatText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(845, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(118, 37);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Lire à partir Fichier";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(827, 238);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(845, 55);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(118, 37);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Sauvegarder dans Fichier";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnFormatText
            // 
            this.btnFormatText.Location = new System.Drawing.Point(845, 98);
            this.btnFormatText.Name = "btnFormatText";
            this.btnFormatText.Size = new System.Drawing.Size(118, 37);
            this.btnFormatText.TabIndex = 3;
            this.btnFormatText.Text = "Mettre en forme";
            this.btnFormatText.UseVisualStyleBackColor = true;
            this.btnFormatText.Click += new System.EventHandler(this.btnFormatText_Click);
            // 
            // Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 262);
            this.Controls.Add(this.btnFormatText);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Editeur";
            this.Text = "Editeur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnFormatText;
    }
}