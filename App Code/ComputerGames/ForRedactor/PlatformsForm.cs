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

namespace ComputerGames.ForRedactor
{
    public partial class PlatformsForm : Form
    {
        public PlatformsForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeletePlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Add");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@des", textBox3.Text.ToString());
                sqlcmd.ExecuteNonQuery();
                Reset();
                MessageBox.Show("Данные добавлены!");
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
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeletePlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Delete");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@des", textBox3.Text.ToString());
                sqlcmd.ExecuteNonQuery();
                Reset();
                MessageBox.Show("Данные удалены!");
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
        //update
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeletePlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@des", textBox3.Text.ToString());
                sqlcmd.ExecuteNonQuery();
                Reset();
                MessageBox.Show("Данные изменены!");
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
        //search
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SearchByNamePlatform", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@name", textBox5.Text.ToString());

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                //dataGridView1.Columns[0].Visible = false;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Platforms WHERE id='" + id + "'", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);


                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();

                }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Main ss = new Main();
            ss.Show();
        }
    }
}
