﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string chaine = @" Data Source=DESKTOP-UPQQNIA\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        private void textboxqueouvert_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd3_Click(object sender, EventArgs e)
        {

        }

        private void btnQancel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAfficher3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewQuestOuvert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
