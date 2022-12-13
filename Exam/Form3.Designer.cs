namespace Exam
{
    partial class Form3
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
            this.lblqueouvert = new System.Windows.Forms.Label();
            this.textboxqueouvert = new System.Windows.Forms.TextBox();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnQancel3 = new System.Windows.Forms.Button();
            this.btnAfficher3 = new System.Windows.Forms.Button();
            this.dataGridViewQuestOuvert = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestOuvert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblqueouvert
            // 
            this.lblqueouvert.AutoSize = true;
            this.lblqueouvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqueouvert.Location = new System.Drawing.Point(72, 64);
            this.lblqueouvert.Name = "lblqueouvert";
            this.lblqueouvert.Size = new System.Drawing.Size(77, 20);
            this.lblqueouvert.TabIndex = 0;
            this.lblqueouvert.Text = "Question ";
            // 
            // textboxqueouvert
            // 
            this.textboxqueouvert.Location = new System.Drawing.Point(214, 64);
            this.textboxqueouvert.Name = "textboxqueouvert";
            this.textboxqueouvert.Size = new System.Drawing.Size(100, 20);
            this.textboxqueouvert.TabIndex = 1;
            this.textboxqueouvert.TextChanged += new System.EventHandler(this.textboxqueouvert_TextChanged);
            // 
            // btnAdd3
            // 
            this.btnAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd3.Location = new System.Drawing.Point(144, 118);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(104, 36);
            this.btnAdd3.TabIndex = 3;
            this.btnAdd3.Text = "Ajouter";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // btnQancel3
            // 
            this.btnQancel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQancel3.Location = new System.Drawing.Point(302, 118);
            this.btnQancel3.Name = "btnQancel3";
            this.btnQancel3.Size = new System.Drawing.Size(104, 36);
            this.btnQancel3.TabIndex = 4;
            this.btnQancel3.Text = "Annuler";
            this.btnQancel3.UseVisualStyleBackColor = true;
            this.btnQancel3.Click += new System.EventHandler(this.btnQancel3_Click);
            // 
            // btnAfficher3
            // 
            this.btnAfficher3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher3.Location = new System.Drawing.Point(441, 118);
            this.btnAfficher3.Name = "btnAfficher3";
            this.btnAfficher3.Size = new System.Drawing.Size(104, 36);
            this.btnAfficher3.TabIndex = 5;
            this.btnAfficher3.Text = "Afficher";
            this.btnAfficher3.UseVisualStyleBackColor = true;
            this.btnAfficher3.Click += new System.EventHandler(this.btnAfficher3_Click);
            // 
            // dataGridViewQuestOuvert
            // 
            this.dataGridViewQuestOuvert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuestOuvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestOuvert.Location = new System.Drawing.Point(144, 178);
            this.dataGridViewQuestOuvert.Name = "dataGridViewQuestOuvert";
            this.dataGridViewQuestOuvert.Size = new System.Drawing.Size(224, 145);
            this.dataGridViewQuestOuvert.TabIndex = 6;
            this.dataGridViewQuestOuvert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestOuvert_CellContentClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewQuestOuvert);
            this.Controls.Add(this.btnAfficher3);
            this.Controls.Add(this.btnQancel3);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.textboxqueouvert);
            this.Controls.Add(this.lblqueouvert);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestOuvert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqueouvert;
        private System.Windows.Forms.TextBox textboxqueouvert;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Button btnQancel3;
        private System.Windows.Forms.Button btnAfficher3;
        private System.Windows.Forms.DataGridView dataGridViewQuestOuvert;
    }
}