using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGames.ForRedactor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgeLimitForm ss = new AgeLimitForm();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigurationForm ss = new ConfigurationForm();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DevelopersForm ss = new DevelopersForm();
            ss.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnginesForm ss = new EnginesForm();
            ss.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GamesPlatformsForm ss = new GamesPlatformsForm();
            ss.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PlatformsForm ss = new PlatformsForm();
            ss.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GenresForm ss = new GenresForm();
            ss.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PublisherDevsForm ss = new PublisherDevsForm();
            ss.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StoresForm ss = new StoresForm();
            ss.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PublishersForm ss = new PublishersForm();
            ss.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LozalizersForm ss = new LozalizersForm();
            ss.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GamesForm ss = new GamesForm();
            ss.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();

            Login ss = new Login();
            ss.Show();
        }
    }
}
