using System;
using System.Data;
using System.Windows.Forms;
using projekpbobismillah.models;
using projekpbobismillah.Controllers; 
namespace projekpbobismillah.form
{
    public partial class RiwayatTransaksiForm : Form
    {
        private Member currentMember;
        private TransaksiController _transaksiController;

        public RiwayatTransaksiForm(Member member)
        {
            InitializeComponent();
            currentMember = member;
            _transaksiController = new TransaksiController();
        }

        private void RiwayatTransaksiForm_Load(object sender, EventArgs e)
        {
            LoadRiwayatTransaksi();
        }
        private void LoadRiwayatTransaksi()
        {
            try
            {
                DataTable dt = _transaksiController.DapatkanRiwayatTransaksi(currentMember.UserID);

                dgvRiwayatTransaksi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load riwayat transaksi: " + ex.Message);
            }
        }
        private void btnBeranda_Click(object sender, EventArgs e)
        {
            MemberDashboard dash = new MemberDashboard(currentMember);
            dash.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm(currentMember);
            history.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfilMember profil = new ProfilMember(currentMember);
            profil.Show();
            this.Hide();
        }

        private void dgvRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}