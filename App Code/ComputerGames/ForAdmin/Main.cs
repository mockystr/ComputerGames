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

namespace ComputerGames.ForAdmin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cGDataSet.LoginTable". При необходимости она может быть перемещена или удалена.
            //this.loginTableTableAdapter.Fill(this.cGDataSet.LoginTable);
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                if (textBox4.Text.Trim() == "User" || textBox4.Text.Trim() == "Admin" || textBox4.Text.Trim() == "Redactor" || textBox4.Text.Trim() == "Moderator")
                {
                    SqlCommand sqlcmd = new SqlCommand("AdminAddOrEdit", con);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Add");
                    sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@role_", textBox4.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }
                else
                    MessageBox.Show("Введите правильно данные!");
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

                SqlDataAdapter da = new SqlDataAdapter("SearchUsersByRole", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@role_", textBox5.Text.Trim());

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
                    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
        //update
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                if (textBox4.Text.Trim() == "User" || textBox4.Text.Trim() == "Admin" || textBox4.Text.Trim() == "Redactor" || textBox4.Text.Trim() == "Moderator")
                {
                    SqlCommand sqlcmd = new SqlCommand("AdminAddOrEdit", con);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlcmd.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@pass", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@role_", textBox4.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Данные изменены!");
                }
                else
                {
                    MessageBox.Show("Введите правильно данные!", "Ошибка");
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

        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand sqlcmd = new SqlCommand("DeleteUser", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login ss = new Login();
            ss.Show();
            this.Close();
        }
    }
}
