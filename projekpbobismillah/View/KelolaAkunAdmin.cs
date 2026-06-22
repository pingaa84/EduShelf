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
using projekpbobismillah.Controllers;

namespace projekpbobismillah.form
{
    public partial class KelolaAkunAdmin : Form
    {
        private KelolaAkunAdminController kelolaAkunController;

        public KelolaAkunAdmin()
        {
            InitializeComponent();
            kelolaAkunController = new KelolaAkunAdminController();
            DataGridView();
        }

        private void DataGridView()
        {
            dgvAkunadmin.AutoGenerateColumns = false;
            dgvAkunadmin.ReadOnly = true;
            dgvAkunadmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAkunadmin.MultiSelect = false;

            dgvAkunadmin.BackgroundColor = Color.FromArgb(245, 245, 245); 
            dgvAkunadmin.BorderStyle = BorderStyle.None;                 
            dgvAkunadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            dgvAkunadmin.Columns.Clear();

            dgvAkunadmin.Columns.Add("admin_id", "ID");
            dgvAkunadmin.Columns["admin_id"].DataPropertyName = "admin_id";
            dgvAkunadmin.Columns["admin_id"].Visible = false;

            dgvAkunadmin.Columns.Add("nama", "Nama");
            dgvAkunadmin.Columns["nama"].DataPropertyName = "nama";
            dgvAkunadmin.Columns.Add("email", "Email");
            dgvAkunadmin.Columns["email"].DataPropertyName = "email";

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Hapus";
            btnDelete.Text = "Hapus";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;

            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnDelete.Width = 100;

            dgvAkunadmin.Columns.Add(btnDelete);

            dgvAkunadmin.CellClick += dgvAkunadmin_CellClick;
        }

        private void dgvAkunadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex >= dgvAkunadmin.Columns.Count)
                return;
            if (dgvAkunadmin.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (dgvAkunadmin.Rows[e.RowIndex].Cells["admin_id"].Value != null)
                {
                    int adminId = Convert.ToInt32(dgvAkunadmin.Rows[e.RowIndex].Cells["admin_id"].Value);
                    DeleteAdmin(adminId);
                }
            }
        }

        private void DeleteAdmin(int id)
        {
            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    kelolaAkunController.HapusAdmin(id);
                    LoadAdminList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus admin: " + ex.Message);
                }
                LoadAdminList();
            }
        }

        private void btnTambahakun_Click(object sender, EventArgs e)
        {
            TambahAkunAdmin form = new TambahAkunAdmin();
            form.ShowDialog();

            if (form.DataSaved)
            {
                LoadAdminList();
            }
        }

        private void dgvAkunadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KelolaAkunAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminList();
        }

        private void LoadAdminList()
        {
            try
            {
                DataTable dt = kelolaAkunController.DapatkanDaftarAdmin();
                dgvAkunadmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load admin: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardAdmin admin = new DashboardAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnManajemen_Click(object sender, EventArgs e)
        {
            ManajemenBukuForm form = new ManajemenBukuForm();
            form.Show();
            this.Hide();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            Subscriptions subscriptions = new Subscriptions();
            subscriptions.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            ManajemenPengguna pengguna = new ManajemenPengguna();
            pengguna.Show();
            this.Hide();
        }
    }
}