using System;
using System.Data;
using System.Windows.Forms;
using projekpbobismillah.Controllers;

namespace projekpbobismillah.form
{
    public partial class DashboardAdmin : Form
    {
        private DashboardAdminController _dashboardController;

        public DashboardAdmin()
        {
            InitializeComponent();
            _dashboardController = new DashboardAdminController();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void DashboardAdmin_Load_1(object sender, EventArgs e)
        {
            MuatUlangDashboard();
        }

        private void MuatUlangDashboard()
        {
            try
            {
                lblTotalBuku.Text = _dashboardController.DapatkanTotalBuku();

                if (chartMemberPremium.Series.Count > 0)
                {
                    var seriesPremium = chartMemberPremium.Series[0];
                    seriesPremium.Points.Clear();

                    DataTable dtPremium = _dashboardController.DapatkanGrafikPremium();
                    foreach (DataRow row in dtPremium.Rows)
                    {
                        string bulan = row["bulan"].ToString().Trim();
                        int total = Convert.ToInt32(row["total"]);
                        seriesPremium.Points.AddXY(bulan, total);
                    }
                }

               
                if (chartMember.Series.Count > 0)
                {
                    var seriesMember = chartMember.Series[0];
                    seriesMember.Points.Clear();

                    DataTable dtMember = _dashboardController.DapatkanGrafikTotalMember();
                    foreach (DataRow row in dtMember.Rows)
                    {
                        string bulan = row["bulan"].ToString().Trim();
                        int total = Convert.ToInt32(row["total"]);
                        seriesMember.Points.AddXY(bulan, total);
                    }
                }

                if (chartRevenue.Series.Count > 0)
                {
                    var seriesRevenue = chartRevenue.Series[0];
                    seriesRevenue.Points.Clear();

                    DataTable dtRevenue = _dashboardController.DapatkanGrafikRevenue();
                    foreach (DataRow row in dtRevenue.Rows)
                    {
                        string bulan = row["bulan"].ToString().Trim();
                        decimal total = Convert.ToDecimal(row["total"]);
                        seriesRevenue.Points.AddXY(bulan, total);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat visualisasi data: " + ex.Message, "Error Visualisasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnManajemenMember_Click(object sender, EventArgs e)
        {
            ManajemenPengguna pengguna = new ManajemenPengguna();
            pengguna.Show();
            this.Hide();
        }

        private void btnKelolaAkun_Click(object sender, EventArgs e)
        {
            KelolaAkunAdmin kelolaAkun = new KelolaAkunAdmin();
            kelolaAkun.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void chartRevenue_Click(object sender, EventArgs e) { }

        private void chartMemberPremium_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}