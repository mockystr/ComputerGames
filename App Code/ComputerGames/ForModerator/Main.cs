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

namespace ComputerGames.ForModerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reset()
        {
            textBox1.Text = "";
            comboBox1.SelectedValue = -1; 
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("DeleteReview", con);

                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Reviews WHERE id='" + id + "'", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);

                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox1.Enabled = false;
                    comboBox1.SelectedValue = dt.Rows[0][1];
                    textBox3.Text = dt.Rows[0][2].ToString();
                    textBox4.Text = dt.Rows[0][3].ToString();
                    textBox5.Text = dt.Rows[0][4].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SearchReviewsByUsername", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@username", textBox6.Text.Trim());

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                if (Convert.ToInt32(textBox4.Text.Trim()) <= 10)
                {
                    SqlCommand sqlcmd = new SqlCommand("EditReview", con);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@game", comboBox1.SelectedValue);
                    sqlcmd.Parameters.AddWithValue("@review", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@rating", textBox4.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@user_", textBox5.Text.Trim());
                    sqlcmd.ExecuteNonQuery();

                    Reset();
                    MessageBox.Show("Данные изменены!");
                }
                else
                    MessageBox.Show("Введите правильно данные");
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
            Login ss = new Login();
            ss.Show();

            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter1.Fill(this.computerGamesDataSet.Games);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.Games". При необходимости она может быть перемещена или удалена.
            //this.gamesTableAdapter.Fill(this.ComputerGamesDataSet.Games);

        }
    }
}
