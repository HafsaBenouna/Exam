using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string chaine = @" Data Source=DESKTOP-UPQQNIA\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPropos1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPropos2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPropos3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into qcm(question,proposition1, proposition2, proposition3) values('" + textBoxQuest.Text + "','" + textBoxPropos1.Text + "','" + textBoxPropos2.Text + "','" + textBoxPropos3.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into qcm( question,proposition1, proposition2, proposition3) values('" + textBoxQuest.Text + "','" + textBoxPropos1.Text + "','" + textBoxPropos2.Text + "','" + textBoxPropos3.Text + "') ";
            cnx.Close();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from qcm";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewQcm.DataSource = dt;
        }

        private void dataGridViewQcm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxQuest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
