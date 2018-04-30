using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ComputerGames.ForUser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamesReport ss = new GamesReport();
            ss.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublisherReport ss = new PublisherReport();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DevelopersReport ss = new DevelopersReport();
            ss.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LocalizersReport ss = new LocalizersReport();
            ss.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfReport ss = new ConfReport();
            ss.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GamesRatingReport ss = new GamesRatingReport();
            ss.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReviewsReport ss = new ReviewsReport();
            ss.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login ss = new Login();
            ss.Show();
            this.Close();
        }
    }
}
