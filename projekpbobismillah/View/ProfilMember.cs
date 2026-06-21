using Npgsql;
using projekpbobismillah.models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class ProfilMember : Form
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        private string fotoPath = "";
        private Member currentMember;

        public ProfilMember(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }
        private void ProfilMember_Load(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                MessageBox.Show("User belum login!");
                this.Close();
                return;
            }

            LoadProfile();
        }
        private void LoadProfile()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM Member WHERE member_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", currentMember.UserID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNamaDepan.Text = reader["nama_depan"].ToString();
                            txtNamaBelakang.Text = reader["nama_belakang"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtNoTelp.Text = reader["no_telepon"].ToString();
                            txtBio.Text = reader["bio"].ToString();

                            fotoPath = reader["foto_profil"].ToString();

                            if (!string.IsNullOrEmpty(fotoPath))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, fotoPath);

                                if (File.Exists(fullPath))
                                {
                                    picProfil.Image = Image.FromFile(fullPath);
                                    picProfil.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                MessageBox.Show("User tidak valid!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    UPDATE Member 
                    SET nama_depan=@namaDepan,
                        nama_belakang=@namaBelakang,
                        email=@email,
                        no_telepon=@telp,
                        bio=@bio,
                        foto_profil=@foto
                    WHERE member_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@namaDepan", txtNamaDepan.Text);
                    cmd.Parameters.AddWithValue("@namaBelakang", txtNamaBelakang.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text);
                    cmd.Parameters.AddWithValue("@bio", txtBio.Text);
                    cmd.Parameters.AddWithValue("@foto", fotoPath ?? "");
                    cmd.Parameters.AddWithValue("@id", currentMember.UserID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Profil berhasil disimpan!");
            LoadProfile();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnRwttrns_Click(object sender, EventArgs e)
        {
            RiwayatTransaksiForm form = new RiwayatTransaksiForm(currentMember);
            form.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(currentMember);
            form.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            MemberDashboard dash = new MemberDashboard(currentMember);
            dash.Show();
            this.Hide();
        }

        private void btnSImpanprofil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);

                string folder = Path.Combine(Application.StartupPath, "Resources", "Profile");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string fullPath = Path.Combine(folder, fileName);

                File.Copy(ofd.FileName, fullPath, true);

                fotoPath = Path.Combine("Resources", "Profile", fileName);

                picProfil.Image = Image.FromFile(fullPath);
                picProfil.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}