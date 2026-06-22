using Npgsql;
using projekpbobismillah.form;
using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekpbobismillah.Controllers
{
    public class LoginController
    {
        private Form _loginForm;

        public LoginController(Form loginForm)
        {
            _loginForm = loginForm;
        }

        public void ProsesLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Admin admin = Admin.ValidasiLoginAdmin(email, password);

                if (admin != null)
                {
                    MessageBox.Show("Login sebagai Admin!");

                    DashboardAdmin adminDash = new DashboardAdmin();
                    adminDash.Show();

                    _loginForm.Hide();
                    return;
                }

                Tuple<Member, string> hasilLoginMember = Member.ValidasiLoginMember(email, password);

                if (hasilLoginMember != null)
                {
                    Member member = hasilLoginMember.Item1;
                    string status = hasilLoginMember.Item2;

                    if (status.ToLower() == "active")
                    {
                        MessageBox.Show("Login berhasil!");

                        MemberDashboard dash = new MemberDashboard(member);
                        dash.Show();
                    }
                    else
                    {
                        MessageBox.Show("Silakan lakukan pembayaran terlebih dahulu.");

                        Payment pay = new Payment(member);
                        pay.Show();
                    }

                    _loginForm.Hide();
                    return;
                }

                MessageBox.Show("Email atau password salah!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error pada sistem login: " + ex.Message);
            }
        }
    }
}
