namespace Exam
{
    partial class Form1
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
            this.menuExam = new System.Windows.Forms.MenuStrip();
            this.creerUnExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerQCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerQuestionOuvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldatedebut = new System.Windows.Forms.Label();
            this.lbldatefin = new System.Windows.Forms.Label();
            this.lblmatiére = new System.Windows.Forms.Label();
            this.textBoxDateDebut = new System.Windows.Forms.TextBox();
            this.textBoxMatiere = new System.Windows.Forms.TextBox();
            this.textBoxDateFin = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnAffich = new System.Windows.Forms.Button();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.menuExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            this.SuspendLayout();
            // 
            // menuExam
            // 
            this.menuExam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnExamToolStripMenuItem});
            this.menuExam.Location = new System.Drawing.Point(0, 0);
            this.menuExam.Name = "menuExam";
            this.menuExam.Size = new System.Drawing.Size(800, 24);
            this.menuExam.TabIndex = 0;
            this.menuExam.Text = "menu";
            // 
            // creerUnExamToolStripMenuItem
            // 
            this.creerUnExamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerQCMToolStripMenuItem,
            this.créerQuestionOuvertToolStripMenuItem});
            this.creerUnExamToolStripMenuItem.Name = "creerUnExamToolStripMenuItem";
            this.creerUnExamToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.creerUnExamToolStripMenuItem.Text = "Créer un exam";
            this.creerUnExamToolStripMenuItem.Click += new System.EventHandler(this.creerUnExamToolStripMenuItem_Click);
            // 
            // créerQCMToolStripMenuItem
            // 
            this.créerQCMToolStripMenuItem.Name = "créerQCMToolStripMenuItem";
            this.créerQCMToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.créerQCMToolStripMenuItem.Text = "Créer QCM";
            this.créerQCMToolStripMenuItem.Click += new System.EventHandler(this.créerQCMToolStripMenuItem_Click);
            // 
            // créerQuestionOuvertToolStripMenuItem
            // 
            this.créerQuestionOuvertToolStripMenuItem.Name = "créerQuestionOuvertToolStripMenuItem";
            this.créerQuestionOuvertToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.créerQuestionOuvertToolStripMenuItem.Text = "Créer Question Ouvert";
            this.créerQuestionOuvertToolStripMenuItem.Click += new System.EventHandler(this.créerQuestionOuvertToolStripMenuItem_Click);
            // 
            // lbldatedebut
            // 
            this.lbldatedebut.AutoSize = true;
            this.lbldatedebut.Location = new System.Drawing.Point(54, 63);
            this.lbldatedebut.Name = "lbldatedebut";
            this.lbldatedebut.Size = new System.Drawing.Size(58, 13);
            this.lbldatedebut.TabIndex = 1;
            this.lbldatedebut.Text = "date début";
            this.lbldatedebut.Click += new System.EventHandler(this.lbldatedebut_Click);
            // 
            // lbldatefin
            // 
            this.lbldatefin.AutoSize = true;
            this.lbldatefin.Location = new System.Drawing.Point(54, 92);
            this.lbldatefin.Name = "lbldatefin";
            this.lbldatefin.Size = new System.Drawing.Size(44, 13);
            this.lbldatefin.TabIndex = 2;
            this.lbldatefin.Text = "Date fin";
            this.lbldatefin.Click += new System.EventHandler(this.lbldatefin_Click);
            // 
            // lblmatiére
            // 
            this.lblmatiére.AutoSize = true;
            this.lblmatiére.Location = new System.Drawing.Point(54, 138);
            this.lblmatiére.Name = "lblmatiére";
            this.lblmatiére.Size = new System.Drawing.Size(42, 13);
            this.lblmatiére.TabIndex = 3;
            this.lblmatiére.Text = "Matiére";
            this.lblmatiére.Click += new System.EventHandler(this.lblmatiére_Click);
            // 
            // textBoxDateDebut
            // 
            this.textBoxDateDebut.Location = new System.Drawing.Point(200, 63);
            this.textBoxDateDebut.Name = "textBoxDateDebut";
            this.textBoxDateDebut.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateDebut.TabIndex = 4;
            this.textBoxDateDebut.TextChanged += new System.EventHandler(this.textBoxDateDebut_TextChanged);
            // 
            // textBoxMatiere
            // 
            this.textBoxMatiere.Location = new System.Drawing.Point(200, 138);
            this.textBoxMatiere.Name = "textBoxMatiere";
            this.textBoxMatiere.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatiere.TabIndex = 5;
            this.textBoxMatiere.TextChanged += new System.EventHandler(this.textBoxMatiere_TextChanged);
            // 
            // textBoxDateFin
            // 
            this.textBoxDateFin.Location = new System.Drawing.Point(200, 101);
            this.textBoxDateFin.Name = "textBoxDateFin";
            this.textBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateFin.TabIndex = 6;
            this.textBoxDateFin.TextChanged += new System.EventHandler(this.textBoxDateFin_TextChanged);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(106, 214);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 7;
            this.btnAdd1.Text = "Ajouter";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnAffich
            // 
            this.btnAffich.Location = new System.Drawing.Point(335, 214);
            this.btnAffich.Name = "btnAffich";
            this.btnAffich.Size = new System.Drawing.Size(75, 23);
            this.btnAffich.TabIndex = 9;
            this.btnAffich.Text = "Afficher";
            this.btnAffich.UseVisualStyleBackColor = true;
            this.btnAffich.Click += new System.EventHandler(this.btnAffich_Click);
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Location = new System.Drawing.Point(403, 42);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewExam.TabIndex = 10;
            this.dataGridViewExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExam_CellContentClick);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(234, 222);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 11;
            this.btnCancel1.Text = "Annuler";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.dataGridViewExam);
            this.Controls.Add(this.btnAffich);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.textBoxDateFin);
            this.Controls.Add(this.textBoxMatiere);
            this.Controls.Add(this.textBoxDateDebut);
            this.Controls.Add(this.lblmatiére);
            this.Controls.Add(this.lbldatefin);
            this.Controls.Add(this.lbldatedebut);
            this.Controls.Add(this.menuExam);
            this.MainMenuStrip = this.menuExam;
            this.Name = "Form1";
            this.menuExam.ResumeLayout(false);
            this.menuExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuExam;
        private System.Windows.Forms.ToolStripMenuItem creerUnExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerQCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerQuestionOuvertToolStripMenuItem;
        private System.Windows.Forms.Label lbldatedebut;
        private System.Windows.Forms.Label lbldatefin;
        private System.Windows.Forms.Label lblmatiére;
        private System.Windows.Forms.TextBox textBoxDateDebut;
        private System.Windows.Forms.TextBox textBoxMatiere;
        private System.Windows.Forms.TextBox textBoxDateFin;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAffich;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.Button btnCancel1;
    }
}

