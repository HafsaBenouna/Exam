using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @" Data Source=DESKTOP-UPQQNIA\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        private void lbldatedebut_Click(object sender, EventArgs e)
        {

        }

        private void lbldatefin_Click(object sender, EventArgs e)
        {

        }

        private void lblmatiére_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void créerQCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myform = new Form2();
            myform.Show();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into exam(dateDebut, DateFin , matiere) values('" + textBoxDateDebut.Text + "','" + textBoxDateFin.Text + "','" + textBoxMatiere.Text + "')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into exam(dateDebut , DateFin , matiere) values('" + textBoxDateDebut.Text + "','" + textBoxDateFin.Text + "','" + textBoxMatiere.Text + "')";
            cnx.Close();
        }

        private void btnAffich_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from exam ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewExam.DataSource = dt;
        }

        private void creerUnExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void créerQuestionOuvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myform = new Form3();
            myform.Show();
        }

        private void textBoxDateDebut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatiere_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
