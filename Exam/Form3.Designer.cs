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
            this.SuspendLayout();
            // 
            // lblqueouvert
            // 
            this.lblqueouvert.AutoSize = true;
            this.lblqueouvert.Location = new System.Drawing.Point(72, 64);
            this.lblqueouvert.Name = "lblqueouvert";
            this.lblqueouvert.Size = new System.Drawing.Size(52, 13);
            this.lblqueouvert.TabIndex = 0;
            this.lblqueouvert.Text = "Question ";
            // 
            // textboxqueouvert
            // 
            this.textboxqueouvert.Location = new System.Drawing.Point(214, 64);
            this.textboxqueouvert.Name = "textboxqueouvert";
            this.textboxqueouvert.Size = new System.Drawing.Size(100, 20);
            this.textboxqueouvert.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxqueouvert);
            this.Controls.Add(this.lblqueouvert);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqueouvert;
        private System.Windows.Forms.TextBox textboxqueouvert;
    }
}