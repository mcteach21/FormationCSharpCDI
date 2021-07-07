namespace WindowsFormsIntro
{
    partial class MaFenetre
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnOpenMDI = new System.Windows.Forms.Button();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnDialogCustom = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValiderSaisie = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbarSec = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(453, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Fermer Fenêtre!";
            this.toolTip1.SetToolTip(this.btnClose, "Cliquez pour Quitter!!");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(453, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Ouvrir Fenêtre";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(138, 37);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(58, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(202, 37);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(58, 20);
            this.txtY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma Position";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(453, 135);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 27);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Couleur Fond";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnOpenMDI
            // 
            this.btnOpenMDI.Location = new System.Drawing.Point(453, 56);
            this.btnOpenMDI.Name = "btnOpenMDI";
            this.btnOpenMDI.Size = new System.Drawing.Size(120, 31);
            this.btnOpenMDI.TabIndex = 6;
            this.btnOpenMDI.Text = "..Fenêtre MDI";
            this.btnOpenMDI.UseVisualStyleBackColor = true;
            this.btnOpenMDI.Click += new System.EventHandler(this.btnOpenMDI_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(138, 67);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(251, 20);
            this.txtKeys.TabIndex = 7;
            this.txtKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeys_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saisir quelque chose..";
            // 
            // txtConsole
            // 
            this.txtConsole.Enabled = false;
            this.txtConsole.Location = new System.Drawing.Point(138, 98);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(251, 78);
            this.txtConsole.TabIndex = 9;
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(453, 169);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(120, 30);
            this.btnDialog.TabIndex = 10;
            this.btnDialog.Text = "Boite Dialogue";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDialogCustom
            // 
            this.btnDialogCustom.Location = new System.Drawing.Point(453, 205);
            this.btnDialogCustom.Name = "btnDialogCustom";
            this.btnDialogCustom.Size = new System.Drawing.Size(120, 52);
            this.btnDialogCustom.TabIndex = 11;
            this.btnDialogCustom.Text = "..Dialogue Custom";
            this.toolTip1.SetToolTip(this.btnDialogCustom, "Cliquez pour afficher ma boite de Dialogue!");
            this.btnDialogCustom.UseVisualStyleBackColor = true;
            this.btnDialogCustom.Click += new System.EventHandler(this.btnDialogCustom_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnValiderSaisie
            // 
            this.btnValiderSaisie.Location = new System.Drawing.Point(453, 263);
            this.btnValiderSaisie.Name = "btnValiderSaisie";
            this.btnValiderSaisie.Size = new System.Drawing.Size(120, 30);
            this.btnValiderSaisie.TabIndex = 12;
            this.btnValiderSaisie.Text = "Error Provider..";
            this.btnValiderSaisie.UseVisualStyleBackColor = true;
            this.btnValiderSaisie.Click += new System.EventHandler(this.btnValiderSaisie_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbarSec
            // 
            this.pbarSec.Location = new System.Drawing.Point(138, 183);
            this.pbarSec.Name = "pbarSec";
            this.pbarSec.Size = new System.Drawing.Size(251, 23);
            this.pbarSec.TabIndex = 13;
            // 
            // MaFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(585, 359);
            this.ControlBox = false;
            this.Controls.Add(this.pbarSec);
            this.Controls.Add(this.btnValiderSaisie);
            this.Controls.Add(this.btnDialogCustom);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.btnOpenMDI);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaFenetre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma Fenetre Principale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaFenetre_FormClosing);
            this.Load += new System.EventHandler(this.MaFenetre_Load);
            this.Move += new System.EventHandler(this.MaFenetre_Move);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnOpenMDI;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnDialogCustom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnValiderSaisie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbarSec;
    }
}