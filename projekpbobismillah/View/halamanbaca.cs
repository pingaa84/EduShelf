using projekpbobismillah.Controllers;
using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class HalamanBaca : Form
    {
        private List<ChapterBaca> chapters = new List<ChapterBaca>();
        private int bukuId;
        private int currentIndex = 0;
        private Member currentMember;
        private int lastReadPage;

        private HalamanBacaController halamanBacaController;


        public HalamanBaca(int bukuId, Member Member, int lastPage)
        {
            InitializeComponent();
            this.bukuId = bukuId;        
            this.currentMember = Member;
            this.lastReadPage = lastPage;

            halamanBacaController = new HalamanBacaController();
        }
        private void halamanbaca_Load(object sender, EventArgs e)
        {
            LoadBookTitle();
            LoadChapters();
            if (chapters.Count > 0)
            {
                
                int targetIndex = lastReadPage - 1;

                if (targetIndex < 0 || targetIndex >= chapters.Count)
                {
                    targetIndex = 0; 
                }
                ShowChapter(targetIndex);

                if (lstChapter.Items.Count > targetIndex)
                {
                    lstChapter.SelectedIndex = targetIndex;
                }

                rtbTulisan.Text = chapters[targetIndex].Isi;
                rtbTulisan.Refresh();
            }
        }

        private void LoadBookTitle()
        {
            try
            {
                lblJudul.Text = halamanBacaController.DapatkanJudulBuku(bukuId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat judul buku: " + ex.Message);
            }
        }

        private void LoadChapters()
        {
            chapters.Clear();
            lstChapter.Items.Clear();

            try
            {
                chapters = halamanBacaController.DapatkanChapterBuku(bukuId);

                foreach (var chapter in chapters)
                {
                    lstChapter.Items.Add(chapter.Judul);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat chapter: " + ex.Message);
            }
        }
        

        private void ShowChapter(int index)
        {
            if (index < 0 || index >= chapters.Count) return;

            currentIndex = index;
            var chapter = chapters[index];

            lblJudulChapter.Text = chapter.Judul;
            rtbTulisan.Text = chapter.Isi;

            lstChapter.SelectedIndex = index;
            SaveHistory(chapter);
        }

        private void SaveHistory(ChapterBaca chapter)
        {
            if (currentMember == null) return;

            try
            {
                halamanBacaController.SimpanHistoryBaca(currentMember.UserID, bukuId, chapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan riwayat baca: " + ex.Message);
            }
        }

        private void lstChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChapter.SelectedIndex >= 0)
                ShowChapter(lstChapter.SelectedIndex);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < chapters.Count - 1)
                ShowChapter(currentIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
                ShowChapter(currentIndex - 1);
        }

        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            MemberDashboard dash = new MemberDashboard(currentMember);
            dash.Show();
            this.Hide();
        }
    }
}