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
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

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
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string queryAdmin = @"
                        SELECT admin_id, nama, email
                        FROM Admin
                        WHERE email=@Email AND password=@Password
                    ";

                    using (var cmdAdmin = new NpgsqlCommand(queryAdmin, conn))
                    {
                        cmdAdmin.Parameters.AddWithValue("Email", email);
                        cmdAdmin.Parameters.AddWithValue("Password", password);

                        using (var reader = cmdAdmin.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login sebagai Admin!");
                                DashboardAdmin adminDash = new DashboardAdmin();
                                adminDash.Show();
                                _loginForm.Hide();
                                return;
                            }
                        }
                    }
                    string queryMember = @"
                        SELECT 
                            m.member_id,
                            m.nama_depan,
                            m.nama_belakang,
                            m.email,
                            COALESCE(s.status,'pending') AS status
                        FROM Member m
                        LEFT JOIN Subscription s
                            ON m.member_id = s.member_id
                            AND s.end_date = (
                                SELECT MAX(end_date) 
                                FROM Subscription 
                                WHERE member_id = m.member_id
                            )
                        WHERE m.email = @Email AND m.password = @Password
                    ";

                    using (var cmdMember = new NpgsqlCommand(queryMember, conn))
                    {
                        cmdMember.Parameters.AddWithValue("Email", email);
                        cmdMember.Parameters.AddWithValue("Password", password);

                        using (var reader = cmdMember.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int memberId = Convert.ToInt32(reader["member_id"]);
                                string nama = reader["nama_depan"].ToString() + " " + reader["nama_belakang"].ToString();
                                string status = reader["status"].ToString();

                                Member member = new Member(memberId, email, password, nama);

                                if (status.ToLower() == "active") // pastikan casing sesuai DB
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
                        }
                    }

                    MessageBox.Show("Email atau password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error pada sistem login: " + ex.Message);
            }
        }
    }

}
