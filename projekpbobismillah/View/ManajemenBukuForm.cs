using projekpbobismillah.models;
using projekpbobismillah.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class ManajemenBukuForm : Form
    {
        private ManajemenBukuController _bukuController;

        public ManajemenBukuForm()
        {
            InitializeComponent();
            _bukuController = new ManajemenBukuController();
        }

        private void ManajemenBukuForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Book> daftarBuku = _bukuController.DapatkanSemuaBuku();

            foreach (var book in daftarBuku)
            {
                AddBookCardUI(book);
            }
        }

        private void AddBookCardUI(Book book)
        {
            Panel panel = new Panel();
            panel.Name = "PnlBook_" + book.IDBuku;
            panel.Size = new Size(150, 220);
            panel.BackColor = Color.White;
            panel.Margin = new Padding(10);
            panel.Tag = book.IDBuku;

            PictureBox pbCover = new PictureBox();
            pbCover.Size = new Size(130, 130);          
            pbCover.Location = new Point(10, 10);        
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;   
            pbCover.Tag = book.IDBuku;

            try
            {
                if (!string.IsNullOrEmpty(book.Cover) && System.IO.File.Exists(book.Cover))
                {
                    byte[] imageBytes = System.IO.File.ReadAllBytes(book.Cover);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pbCover.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error load cover: " + ex.Message);
            }

            // =========================================================================

            Label title = new Label();
            title.Text = book.Judul;
            title.Location = new Point(10, 150); 
            title.AutoSize = true;
            title.Tag = book.IDBuku;

            Label author = new Label();
            author.Text = book.Author;
            author.Location = new Point(10, 170);
            author.ForeColor = Color.Gray;
            author.AutoSize = true;
            author.Tag = book.IDBuku;

            Button btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Location = new Point(2, 185);
            btnEdit.Click += (s, e) => EditBook(book);

            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(73, 185);
            btnDelete.Click += (s, e) => DeleteBook(book.IDBuku);

            panel.Controls.Add(pbCover);

            panel.Controls.Add(title);
            panel.Controls.Add(author);
            panel.Controls.Add(btnEdit);
            panel.Controls.Add(btnDelete);

            panel.DoubleClick += (s, e) => OpenBookReader(book);

            flowLayoutPanel1.Controls.Add(panel);
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void EditBook(Book book)
        {
            AddEditBook form = new AddEditBook(book);
            form.ShowDialog();

            if (form.DataSaved)
            {
                bool sukses = _bukuController.ProsesUpdateBuku(book);
                if (sukses)
                {
                    MessageBox.Show("Book updated");
                    LoadBooks();
                }
            }
        }

        private void DeleteBook(string id)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus buku ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bukuController.ProsesHapusBuku(id);
                LoadBooks();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditBook form = new AddEditBook();

            if (form.ShowDialog() == DialogResult.OK)
            { 
                LoadBooks();
            }
        }

        private void OpenBookReader(Book book)
        {
            MessageBox.Show("Membuka buku: " + book.Judul, "Reader Mode");
        }

        private void btnManajemenMember_Click(object sender, EventArgs e)
        {
            new ManajemenPengguna().Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            new Subscriptions().Show();
            this.Hide();
        }

        private void btnKelolaAkun_Click(object sender, EventArgs e)
        {
            KelolaAkunAdmin kelolaAkun = new KelolaAkunAdmin();
            kelolaAkun.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}