using System;
using System.Windows.Forms;
using projekpbobismillah.models;
using projekpbobismillah.Controllers; 

namespace projekpbobismillah.form
{
    public partial class Daftarakun : Form
    {
        private string initialEmail;
        private DaftarAkunController _registrasiController;

        public Daftarakun()
        {
            InitializeComponent();
            _registrasiController = new DaftarAkunController();
        }

        public Daftarakun(string email)
        {
            InitializeComponent();
            _registrasiController = new DaftarAkunController();
            initialEmail = email;
            txtEmail.Text = initialEmail;
        }

        private void Daftarakun_Load(object sender, EventArgs e)
        {
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        // ================= DAFTAR AKUN =================
        private void btnDaftarAkun_Click_1(object sender, EventArgs e)
        {
            string namaLengkap = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtSandi.Text.Trim();
            string confirmPassword = txtKonfirSandi.Text.Trim();

            
            if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                Member newMember = _registrasiController.ProsesDaftar(namaLengkap, email, password);

                if (newMember != null)
                {
                    MessageBox.Show("Akun berhasil dibuat! Lanjut ke pembayaran.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Payment paymentForm = new Payment(newMember);
                    paymentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal mendaftarkan akun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}