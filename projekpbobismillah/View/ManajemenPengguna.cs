using System;
using System.Data;
using System.Windows.Forms;
using projekpbobismillah.Controllers; 

namespace projekpbobismillah.form
{
    public partial class ManajemenPengguna : Form
    {
        private ManajemenPenggunaController _memberController;

        public ManajemenPengguna()
        {
            InitializeComponent();
            _memberController = new ManajemenPenggunaController();
        }

        private void ManajemenPengguna_Load(object sender, EventArgs e)
        {
            LoadDataMember();
        }
        private void LoadDataMember()
        {
            try
            {
                DataTable dt = _memberController.DapatkanDaftarMember();

                dgvMember.DataSource = dt;
                dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardAdmin admin = new DashboardAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnManajemenBuku_Click(object sender, EventArgs e)
        {
            ManajemenBukuForm formBuku = new ManajemenBukuForm();
            formBuku.Show();
            this.Hide();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            Subscriptions subs = new Subscriptions();
            subs.Show();
            this.Hide();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnKelolaAkun_Click(object sender, EventArgs e)
        {
            KelolaAkunAdmin kelolaAkun = new KelolaAkunAdmin();
            kelolaAkun.Show();
            this.Hide();
        }
    }
}