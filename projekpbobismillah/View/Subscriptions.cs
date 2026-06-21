using System;
using System.Data;
using System.Windows.Forms;
using projekpbobismillah.Controllers; 
namespace projekpbobismillah.form
{
    public partial class Subscriptions : Form
    {
        private SubscriptionController _subController;

        public Subscriptions()
        {
            InitializeComponent();
            _subController = new SubscriptionController();
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {
            LoadDataSubscription();
        }
        private void LoadDataSubscription()
        {
            try
            {
                DataTable dt = _subController.DapatkanDaftarSubscription();
                dgvSubscription.DataSource = dt;
                dgvSubscription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data langganan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSubscription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string namaKolom = dgvSubscription.Columns[e.ColumnIndex].Name;
            int subId = Convert.ToInt32(dgvSubscription.Rows[e.RowIndex].Cells["subscription_id"].Value);

            if (namaKolom == "btnSetuju")
            {
                _subController.SetujuiLangganan(subId);
                MessageBox.Show("Langganan berhasil disetujui (Aktif)!");
                LoadDataSubscription();
            }
            else if (namaKolom == "btnTolak")
            {
                _subController.TolakLangganan(subId);
                MessageBox.Show("Langganan berhasil ditolak.");
                LoadDataSubscription();
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
      
            this.Hide();
        }



        private void btnManajemenMemb_Click(object sender, EventArgs e)
        {
            new ManajemenPengguna().Show();
            this.Hide();
        }

        private void btnMAnajemenBuku_Click_1(object sender, EventArgs e)
        {
            new ManajemenBukuForm().Show();
            this.Hide();
        }

        private void btnKelolaAkun_Click(object sender, EventArgs e)
        {
            KelolaAkunAdmin kelolaAkun = new KelolaAkunAdmin();
            kelolaAkun.Show();
            this.Hide();
        }
    }
}