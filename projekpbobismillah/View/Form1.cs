using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekpbobismillah.models;
using System.Windows.Forms;

namespace projekpbobismillah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            LoginForm login = new LoginForm();
            login.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
