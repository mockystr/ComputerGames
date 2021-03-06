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
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Configurations_ WHERE id='" + id + "'", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);


                    textBox1.Text = dt.Rows[0][0].ToString();
                    comboBox1.SelectedValue = dt.Rows[0][1];
                    textBox3.Text = dt.Rows[0][2].ToString();
                    textBox2.Text = dt.Rows[0][3].ToString();
                    textBox5.Text = dt.Rows[0][4].ToString();
                    comboBox2.SelectedValue = dt.Rows[0][5];
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
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteConf", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Add");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@CP", textBox3.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@RAM", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@VGA", textBox5.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@engine", comboBox2.SelectedValue);
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

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteConf", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Delete");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@CP", textBox3.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@RAM", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@VGA", textBox5.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@engine", comboBox2.SelectedValue);
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

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteConf", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@CP", textBox3.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@RAM", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@VGA", textBox5.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@engine", comboBox2.SelectedValue);
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

                SqlDataAdapter da = new SqlDataAdapter("SearchByGameConf", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@game", textBox4.Text.ToString());

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Main ss = new Main();
            ss.Show();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Engines". При необходимости она может быть перемещена или удалена.
            this.enginesTableAdapter1.Fill(this.computerGamesDataSet.Engines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter1.Fill(this.computerGamesDataSet.Games);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Engines". При необходимости она может быть перемещена или удалена.
            //this.enginesTableAdapter.Fill(this.cGDataSet.Engines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Games". При необходимости она может быть перемещена или удалена.
            //this.gamesTableAdapter.Fill(this.cGDataSet.Games);

        }        
    }
}
