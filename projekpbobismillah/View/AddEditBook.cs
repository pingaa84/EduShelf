using Npgsql;
using projekpbobismillah.models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class AddEditBook : Form
    {
        public Book NewBook { get; set; }
        public bool DataSaved { get; set; } = false;

        private int bukuId = 0;
        private Book editBook;

        public string CoverPath { get; set; }

        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
        public AddEditBook()
        {
            InitializeComponent();
        }

        public AddEditBook(Book book)
        {
            InitializeComponent();

            editBook = book;

            int.TryParse(book.IDBuku, out bukuId);

            txtTitle.Text = book.Judul;
            txtAuthor.Text = book.Author;
            CoverPath = book.Cover;
        }
        private void AddEditBook_Load(object sender, EventArgs e)
        {
            LoadKategori();

            if (!string.IsNullOrEmpty(CoverPath))
            {
                string path = Path.Combine(Application.StartupPath, CoverPath);

                if (File.Exists(path))
                {
                    picCover.Image = Image.FromFile(path);
                    picCover.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            if (editBook != null)
            {
                for (int i = 0; i < cmbKategori.Items.Count; i++)
                {
                    ComboBoxItem item = cmbKategori.Items[i] as ComboBoxItem;

                    if (item != null &&
                        Convert.ToInt32(item.Value) == Convert.ToInt32(editBook.IDCategory))
                    {
                        cmbKategori.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void LoadKategori()
        {
            cmbKategori.Items.Clear();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT kategori_id, nama_kategori FROM Kategori";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbKategori.Items.Add(new ComboBoxItem
                        {
                            Text = reader["nama_kategori"].ToString(),
                            Value = reader["kategori_id"]
                        });
                    }
                }
            }
        }
        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = Path.GetFileName(ofd.FileName);

                    string folder = Path.Combine(Application.StartupPath, "Resources", "Cover");

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    string fullPath = Path.Combine(folder, fileName);

                    File.Copy(ofd.FileName, fullPath, true);

                    CoverPath = Path.Combine("Resources", "Cover", fileName);

                    picCover.Image = Image.FromFile(fullPath);
                    picCover.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Upload cover gagal: " + ex.Message);
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Judul dan Author wajib diisi!");
                return;
            }

            if (cmbKategori.SelectedItem == null)
            {
                MessageBox.Show("Kategori wajib dipilih!");
                return;
            }

            ComboBoxItem kategori = (ComboBoxItem)cmbKategori.SelectedItem;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query;

                if (editBook == null)
                {
                    query = @"
                        INSERT INTO Buku 
                        (judul, penulis, cover, kategori_id)
                        VALUES 
                        (@judul, @penulis, @cover, @kategori)";
                }
                else
                {
                    query = @"
                        UPDATE Buku 
                        SET judul=@judul,
                            penulis=@penulis,
                            cover=@cover,
                            kategori_id=@kategori
                        WHERE buku_id=@id";
                }

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@judul", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@penulis", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@cover", CoverPath ?? "");
                    cmd.Parameters.AddWithValue("@kategori", Convert.ToInt32(kategori.Value));

                    if (editBook != null)
                        cmd.Parameters.AddWithValue("@id", bukuId);

                    cmd.ExecuteNonQuery();
                }
            }

            DataSaved = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnManageChapter_Click(object sender, EventArgs e)
        {
            if (bukuId <= 0)
            {
                MessageBox.Show("Buku belum tersimpan!");
                return;
            }

            ChapterForm form = new ChapterForm(bukuId, txtTitle.Text);
            form.Show();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}