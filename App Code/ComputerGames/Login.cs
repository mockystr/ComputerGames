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

namespace ComputerGames
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9AVGMCV\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True");

                SqlDataAdapter sda = new SqlDataAdapter("SELECT role_ FROM LoginTable WHERE username='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'", con);
                DataTable dt = new System.Data.DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBoxButtons mbb = MessageBoxButtons.OK;
                    MessageBox.Show("Вы ввели неправильно логин или пароль", "Ошибка!", mbb);
                }
                else if (dt.Rows[0][0].ToString() == "Admin")
                {
                    this.Hide();

                    ForAdmin.Main ss = new ForAdmin.Main();
                    ss.Show();
                }
                else if (dt.Rows[0][0].ToString() == "User")
                {
                    this.Hide();

                    ForUser.Main ss = new ForUser.Main();
                    ss.Show();
                }
                else if (dt.Rows[0][0].ToString() == "Moderator")
                {
                    this.Hide();

                    ForModerator.Main ss = new ForModerator.Main();
                    ss.Show();
                }
                else if (dt.Rows[0][0].ToString() == "Redactor")
                {
                    this.Hide();

                    ForRedactor.Main ss = new ForRedactor.Main();
                    ss.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
