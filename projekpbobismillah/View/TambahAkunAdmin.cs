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
    public partial class TambahAkunAdmin : Form
    {
        private KelolaAkunAdminController kelolaAkunController;

        public bool DataSaved { get; set; } = false;

        public TambahAkunAdmin()
        {
            InitializeComponent();
            kelolaAkunController = new KelolaAkunAdminController();
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
                kelolaAkunController.TambahAdmin(email, password);

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
    
