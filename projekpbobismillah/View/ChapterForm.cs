using System;
using System.Data;
using System.Windows.Forms;
using projekpbobismillah.Controllers; 
namespace projekpbobismillah.form
{
    public partial class ChapterForm : Form
    {
        private int selectedBukuId;
        private int selectedChapterId;
        private DataTable dtCurrentChapters;

        private ChapterController _chapterController;

        public ChapterForm()
        {
            InitializeComponent();
            _chapterController = new ChapterController();
        }

        public ChapterForm(int bukuId, string judulBuku)
        {
            InitializeComponent();
            _chapterController = new ChapterController();

            selectedBukuId = bukuId;
            lblJudulBuku.Text = "Judul Buku: " + judulBuku;
        }

        private void ChapterForm_Load(object sender, EventArgs e)
        {
            if (selectedBukuId <= 0)
            {
                MessageBox.Show("Buku tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoadChapter();
        }

        private void LoadChapter()
        {
            lstChapter.Items.Clear();
            dtCurrentChapters = _chapterController.DapatkanDaftarChapter(selectedBukuId);

            foreach (DataRow row in dtCurrentChapters.Rows)
            {
                lstChapter.Items.Add(row["chapter_number"] + ". " + row["chapter_title"]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtChapterNumber.Text) || string.IsNullOrEmpty(txtChapterTitle.Text))
                {
                    MessageBox.Show("Nomor dan Judul Bab wajib diisi!");
                    return;
                }

                _chapterController.SimpanChapterBaru(selectedBukuId, txtChapterNumber.Text, txtChapterTitle.Text, txtIsiChapter.Text);

                MessageBox.Show("Bab berhasil ditambahkan!");
                LoadChapter();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah bab: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedChapterId <= 0)
            {
                MessageBox.Show("Silakan pilih bab dari daftar terlebih dahulu.");
                return;
            }

            try
            {
                _chapterController.PerbaruiChapter(selectedChapterId, txtChapterNumber.Text, txtChapterTitle.Text, txtIsiChapter.Text);

                MessageBox.Show("Bab berhasil diperbarui!");
                LoadChapter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui bab: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedChapterId <= 0)
            {
                MessageBox.Show("Silakan pilih bab dari daftar terlebih dahulu.");
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus bab ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _chapterController.ProsesHapusChapter(selectedChapterId);

                    MessageBox.Show("Bab berhasil dihapus!");
                    LoadChapter();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus bab: " + ex.Message);
                }
            }
        }

        private void lstChapter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstChapter.SelectedIndex == -1 || dtCurrentChapters == null) return;

            DataRow selectedRow = dtCurrentChapters.Rows[lstChapter.SelectedIndex];

            selectedChapterId = Convert.ToInt32(selectedRow["chapter_id"]);
            txtChapterNumber.Text = selectedRow["chapter_number"].ToString();
            txtChapterTitle.Text = selectedRow["chapter_title"].ToString();
            txtIsiChapter.Text = selectedRow["isi_chapter"].ToString();
        }

        private void ClearForm()
        {
            txtChapterNumber.Clear();
            txtChapterTitle.Clear();
            txtIsiChapter.Clear();
            selectedChapterId = 0;
        }
    }
}