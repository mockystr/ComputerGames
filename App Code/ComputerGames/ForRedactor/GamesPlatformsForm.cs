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
    public partial class GamesPlatformsForm : Form
    {
        public GamesPlatformsForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            //comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GamesPlatformsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.GamePlatform". При необходимости она может быть перемещена или удалена.
            this.gamePlatformTableAdapter1.Fill(this.computerGamesDataSet.GamePlatform);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Platforms". При необходимости она может быть перемещена или удалена.
            this.platformsTableAdapter1.Fill(this.computerGamesDataSet.Platforms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter1.Fill(this.computerGamesDataSet.Games);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Platforms". При необходимости она может быть перемещена или удалена.
            //this.platformsTableAdapter.Fill(this.cGDataSet.Platforms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Games". При необходимости она может быть перемещена или удалена.
            //this.gamesTableAdapter.Fill(this.cGDataSet.Games);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.GamePlatform". При необходимости она может быть перемещена или удалена.
            //this.gamePlatformTableAdapter.Fill(this.cGDataSet.GamePlatform);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGamesPlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Add");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@platform", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@des", textBox2.Text.ToString());
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
        //double click
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM GamePlatform WHERE id='" + id + "'", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);


                    textBox1.Text = dt.Rows[0][0].ToString();
                    comboBox1.SelectedValue = dt.Rows[0][1];
                    comboBox2.SelectedValue = dt.Rows[0][2];
                    textBox2.Text = dt.Rows[0][3].ToString();
                    
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
        //close
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Main ss = new Main();
            ss.Show();
        }
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGamesPlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Delete");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@platform", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@des", textBox2.Text.ToString());
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

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGamesPlatforms", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@platform", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@des", textBox2.Text.ToString());
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SearchByGamePlatform", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@game", comboBox3.SelectedValue);

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.GPV", con);

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
    }
}