using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class TambahAkunAdmin : Form
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public bool DataSaved { get; set; } = false;

        public TambahAkunAdmin()
        {
            InitializeComponent();
        }

        private void TambahAkunAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password wajib diisi!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string queryHitung = "SELECT COUNT(*) FROM Admin";
                    int totalAdminSekarang = 0;
                    using (var cmdHitung = new NpgsqlCommand(queryHitung, conn))
                    {
                        totalAdminSekarang = Convert.ToInt32(cmdHitung.ExecuteScalar());
                    }
                    int nomorAdminBaru = totalAdminSekarang + 1;
                    string namaOtomatis = "Admin " + nomorAdminBaru;

                    string queryInsert = @"
                        INSERT INTO Admin(email, password, nama) 
                        VALUES(@Email, @Password, @Nama)
                    ";

                    using (var cmdInsert = new NpgsqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("Email", email);
                        cmdInsert.Parameters.AddWithValue("Password", password);
                        cmdInsert.Parameters.AddWithValue("Nama", namaOtomatis); // Memakai nama otomatis

                        cmdInsert.ExecuteNonQuery();
                    }
                }

                DataSaved = true;
                MessageBox.Show("Admin berhasil ditambahkan!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan admin: " + ex.Message);
            }
        }
    }
}
    
