using projekpbobismillah.Controllers;
using projekpbobismillah.models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace projekpbobismillah.form
{
    public partial class ProfilMember : Form
    {
        private string fotoPath = "";
        private Member currentMember;
        private ProfilMemberController _profilController;

        public ProfilMember(Member member)
        {
            InitializeComponent();
            currentMember = member;
            _profilController = new ProfilMemberController();
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
            try
            {
                DataTable dt = _profilController.DapatkanProfilMember(currentMember.UserID);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtNamaDepan.Text = row["nama_depan"].ToString();
                    txtNamaBelakang.Text = row["nama_belakang"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtNoTelp.Text = row["no_telepon"].ToString();
                    txtBio.Text = row["bio"].ToString();

                    fotoPath = row["foto_profil"].ToString();

                    if (!string.IsNullOrEmpty(fotoPath))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, fotoPath);

                        if (File.Exists(fullPath))
                        {
                            picProfil.Image = Image.FromFile(fullPath);
                            picProfil.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            picProfil.Image = null;
                        }
                    }
                    else
                    {
                        picProfil.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat profil: " + ex.Message);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                MessageBox.Show("User tidak valid!");
                return;
            }

            try
            {
                bool sukses = _profilController.SimpanProfilMember(
                    currentMember.UserID,
                    txtNamaDepan.Text,
                    txtNamaBelakang.Text,
                    txtEmail.Text,
                    txtNoTelp.Text,
                    txtBio.Text,
                    fotoPath
                );

                if (sukses)
                {
                    MessageBox.Show("Profil berhasil disimpan!");
                    LoadProfile();
                }
                else
                {
                    MessageBox.Show("Profil gagal disimpan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan profil: " + ex.Message);
            }
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