﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComputerGames.ForUser
{
    public partial class DevelopersReport : Form
    {
        public DevelopersReport()
        {
            InitializeComponent();
            Search();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void Search()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SearchByCompanyDev", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@company", textBox1.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForUser.Main ss = new ForUser.Main();
            ss.Show();
            this.Hide();
        }
    }
}
