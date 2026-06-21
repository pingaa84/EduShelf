using Npgsql;
using projekpbobismillah.Controllers;
using projekpbobismillah.form;
using projekpbobismillah.models;
using System;
using System.Windows.Forms;

namespace projekpbobismillah 
{
    public partial class LoginForm : Form
    {
        private LoginController _loginController;

        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController(this);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Daftarakun form = new Daftarakun();
            form.Show();
            this.Hide();
        }

        private void btnMasuk_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            _loginController.ProsesLogin(email, password);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}