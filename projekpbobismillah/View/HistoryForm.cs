using Npgsql;
using projekpbobismillah.models;
using System;
using System.Data;
using projekpbobismillah.Controllers;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class HistoryForm : Form
    {
        private Member currentMember;
        private HistoryController _HistoryController;

        public HistoryForm(Member member)
        {
            InitializeComponent();
            currentMember = member;

            _HistoryController = new HistoryController();

            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.MultiSelect = false;

            dgvHistory.Columns.Clear();

            int indexBukuId = dgvHistory.Columns.Add("buku_id", "Buku ID");
            dgvHistory.Columns[indexBukuId].DataPropertyName = "buku_id";
            dgvHistory.Columns[indexBukuId].Visible = false;

            int indexJudul = dgvHistory.Columns.Add("judul", "Judul Buku");
            dgvHistory.Columns[indexJudul].DataPropertyName = "judul";
            dgvHistory.Columns[indexJudul].Width = 250;

            int indexPenulis = dgvHistory.Columns.Add("penulis", "Penulis");
            dgvHistory.Columns[indexPenulis].DataPropertyName = "penulis";
            dgvHistory.Columns[indexPenulis].Width = 150;

            int indexChapter = dgvHistory.Columns.Add("chapter_title", "Chapter Terakhir");
            dgvHistory.Columns[indexChapter].DataPropertyName = "chapter_title";
            dgvHistory.Columns[indexChapter].Width = 180;

            int indexHalaman = dgvHistory.Columns.Add("halaman_terakhir", "Halaman Terakhir");
            dgvHistory.Columns[indexHalaman].DataPropertyName = "halaman_terakhir";
            dgvHistory.Columns[indexHalaman].Width = 120;
        }
        private void LoadHistory()
        {
            try
            {
                DataTable dt = _HistoryController.DapatkanRiwayat(currentMember.UserID);

                dgvHistory.AutoGenerateColumns = true;
                dgvHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load history: " + ex.Message);
            }
        }

        private void HistoryForm_Load_1(object sender, EventArgs e)
        {
            LoadHistory();
        }
        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = ((DataRowView)dgvHistory.Rows[e.RowIndex].DataBoundItem).Row;

            int bukuId = Convert.ToInt32(dataRow["buku_id"]);
            int lastPage = Convert.ToInt32(dataRow["halaman_terakhir"]);

            HalamanBaca reader = new HalamanBaca(bukuId, currentMember, lastPage);
            reader.Show();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MemberDashboard dash = new MemberDashboard(currentMember);
            dash.Show();
            this.Hide();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            RiwayatTransaksiForm form = new RiwayatTransaksiForm(currentMember);
            form.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            ProfilMember profil = new ProfilMember(currentMember);
            profil.Show();
            this.Hide();
        }
    }
}