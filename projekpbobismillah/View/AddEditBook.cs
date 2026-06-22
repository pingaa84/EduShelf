using Npgsql;
using projekpbobismillah.Controllers;
using projekpbobismillah.models;
using System;
using System.Data;
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

        private AddEditBookController addEditBookController;
        public AddEditBook()
        {
            InitializeComponent();
            addEditBookController = new AddEditBookController();
        }

        public AddEditBook(Book book)
        {
            InitializeComponent();
            addEditBookController = new AddEditBookController();

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

            try
            {
                DataTable dt = addEditBookController.DapatkanKategori();

                foreach (DataRow row in dt.Rows)
                {
                    cmbKategori.Items.Add(new ComboBoxItem
                    {
                        Text = row["nama_kategori"].ToString(),
                        Value = row["kategori_id"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat kategori: " + ex.Message);
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

            try
            {
                ComboBoxItem kategori = (ComboBoxItem)cmbKategori.SelectedItem;

                Book book = new Book
                {
                    IDBuku = editBook == null ? "" : bukuId.ToString(),
                    Judul = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    Cover = CoverPath ?? "",
                    IDCategory = Convert.ToInt32(kategori.Value)
                };

                int savedBookId = addEditBookController.SimpanBuku(book, book.IDCategory);

                bukuId = savedBookId;

                if (editBook != null)
                {
                    editBook.IDBuku = savedBookId.ToString();
                    editBook.Judul = book.Judul;
                    editBook.Author = book.Author;
                    editBook.Cover = book.Cover;
                    editBook.IDCategory = book.IDCategory;
                }

                DataSaved = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan buku: " + ex.Message);
            }
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