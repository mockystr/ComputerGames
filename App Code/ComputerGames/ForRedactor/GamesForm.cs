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

namespace ComputerGames.ForRedactor
{
    public partial class GamesForm : Form
    {
        public GamesForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");
        
        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedValue = -1;
            comboBox2.SelectedValue = -1;
            comboBox3.SelectedValue = -1;
            comboBox4.SelectedValue = -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GamesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Stores". При необходимости она может быть перемещена или удалена.
            this.storesTableAdapter1.Fill(this.computerGamesDataSet.Stores);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Publishers". При необходимости она может быть перемещена или удалена.
            this.publishersTableAdapter1.Fill(this.computerGamesDataSet.Publishers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter1.Fill(this.computerGamesDataSet.Genres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.AgeLimits". При необходимости она может быть перемещена или удалена.
            this.ageLimitsTableAdapter1.Fill(this.computerGamesDataSet.AgeLimits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Stores". При необходимости она может быть перемещена или удалена.
            //this.storesTableAdapter.Fill(this.cGDataSet.Stores);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Publishers". При необходимости она может быть перемещена или удалена.
            //this.publishersTableAdapter.Fill(this.cGDataSet.Publishers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Genres". При необходимости она может быть перемещена или удалена.
            //this.genresTableAdapter.Fill(this.cGDataSet.Genres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.AgeLimits". При необходимости она может быть перемещена или удалена.
            //this.ageLimitsTableAdapter.Fill(this.cGDataSet.AgeLimits);

        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGames", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Add");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name_", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@size", textBox3.Text.Trim());

                sqlcmd.Parameters.AddWithValue("@limit", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@genre", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@publisher", comboBox3.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@store", comboBox4.SelectedValue);

                sqlcmd.Parameters.AddWithValue("@price", textBox4.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@release_d", textBox5.Text.Trim());

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

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGames", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Delete");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name_", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@size", textBox3.Text.Trim());

                sqlcmd.Parameters.AddWithValue("@limit", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@genre", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@publisher", comboBox3.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@store", comboBox4.SelectedValue);

                sqlcmd.Parameters.AddWithValue("@price", textBox4.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@release_d", textBox5.Text.Trim());
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

                SqlCommand sqlcmd = new SqlCommand("AddEditDeleteGames", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@name_", textBox2.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@size", textBox3.Text.Trim());

                sqlcmd.Parameters.AddWithValue("@limit", comboBox1.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@genre", comboBox2.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@publisher", comboBox3.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@store", comboBox4.SelectedValue);

                sqlcmd.Parameters.AddWithValue("@price", textBox4.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@release_d", textBox5.Text.Trim());
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

                SqlDataAdapter da = new SqlDataAdapter("SearchByNameGame", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@name", textBox6.Text.Trim());

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
        //close
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Main ss = new Main();
            ss.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Games WHERE id='" + id + "'", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);

                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();
                    textBox3.Text = dt.Rows[0][2].ToString();

                    comboBox1.SelectedValue = dt.Rows[0][3];
                    comboBox2.SelectedValue = dt.Rows[0][4];
                    comboBox3.SelectedValue = dt.Rows[0][5];
                    comboBox4.SelectedValue = dt.Rows[0][6];

                    textBox4.Text = dt.Rows[0][7].ToString();
                    textBox5.Text = dt.Rows[0][8].ToString();
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
    }
}
