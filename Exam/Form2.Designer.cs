namespace Exam
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.dataGridViewQcm = new System.Windows.Forms.DataGridView();
            this.textBoxPropos1 = new System.Windows.Forms.TextBox();
            this.textBoxPropos3 = new System.Windows.Forms.TextBox();
            this.textBoxPropos2 = new System.Windows.Forms.TextBox();
            this.textBoxQuest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQcm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proposition1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proposition2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proposition3";
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(80, 190);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 4;
            this.btnAdd2.Text = "ADD";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(381, 190);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 5;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(238, 190);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 6;
            this.btnCancel2.Text = "Annuler";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // dataGridViewQcm
            // 
            this.dataGridViewQcm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQcm.Location = new System.Drawing.Point(532, 63);
            this.dataGridViewQcm.Name = "dataGridViewQcm";
            this.dataGridViewQcm.Size = new System.Drawing.Size(227, 179);
            this.dataGridViewQcm.TabIndex = 7;
            this.dataGridViewQcm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQcm_CellContentClick);
            // 
            // textBoxPropos1
            // 
            this.textBoxPropos1.Location = new System.Drawing.Point(200, 41);
            this.textBoxPropos1.Name = "textBoxPropos1";
            this.textBoxPropos1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropos1.TabIndex = 8;
            this.textBoxPropos1.TextChanged += new System.EventHandler(this.textBoxPropos1_TextChanged);
            // 
            // textBoxPropos3
            // 
            this.textBoxPropos3.Location = new System.Drawing.Point(200, 101);
            this.textBoxPropos3.Name = "textBoxPropos3";
            this.textBoxPropos3.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropos3.TabIndex = 9;
            this.textBoxPropos3.TextChanged += new System.EventHandler(this.textBoxPropos3_TextChanged);
            // 
            // textBoxPropos2
            // 
            this.textBoxPropos2.Location = new System.Drawing.Point(200, 68);
            this.textBoxPropos2.Name = "textBoxPropos2";
            this.textBoxPropos2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropos2.TabIndex = 10;
            this.textBoxPropos2.TextChanged += new System.EventHandler(this.textBoxPropos2_TextChanged);
            // 
            // textBoxQuest
            // 
            this.textBoxQuest.Location = new System.Drawing.Point(200, 9);
            this.textBoxQuest.Name = "textBoxQuest";
            this.textBoxQuest.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuest.TabIndex = 11;
            this.textBoxQuest.TextChanged += new System.EventHandler(this.textBoxQuest_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuest);
            this.Controls.Add(this.textBoxPropos2);
            this.Controls.Add(this.textBoxPropos3);
            this.Controls.Add(this.textBoxPropos1);
            this.Controls.Add(this.dataGridViewQcm);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQcm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.DataGridView dataGridViewQcm;
        private System.Windows.Forms.TextBox textBoxPropos1;
        private System.Windows.Forms.TextBox textBoxPropos3;
        private System.Windows.Forms.TextBox textBoxPropos2;
        private System.Windows.Forms.TextBox textBoxQuest;
    }
}