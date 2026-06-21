using Npgsql;
using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class halamanbaca : Form
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        private List<Chapter> chapters = new List<Chapter>();
        private int bukuId;
        private int currentIndex = 0;
        private Member currentMember;
        private int lastReadPage;
        private int halamanTerakhir;

        public halamanbaca(int bukuId, Member Member, int lastPage)
        {
            InitializeComponent();
            this.bukuId = bukuId;        
            this.currentMember = Member;
            this.lastReadPage = lastPage;
        }
        private void halamanbaca_Load(object sender, EventArgs e)
        {
            LoadBookTitle();
            LoadChapters();
            if (chapters.Count > 0)
            {
                
                int targetIndex = halamanTerakhir - 1;

                if (targetIndex < 0 || targetIndex >= chapters.Count)
                {
                    targetIndex = 0; 
                }

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
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT judul FROM Buku WHERE buku_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bukuId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        lblJudul.Text = result.ToString();
                }
            }
        }

        private void LoadChapters()
        {
            chapters.Clear();
            lstChapter.Items.Clear();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT * FROM Chapter
                    WHERE buku_id=@id
                    ORDER BY chapter_number ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bukuId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Chapter ch = new Chapter
                            {
                                Id = Convert.ToInt32(reader["chapter_id"]),
                                Judul = reader["chapter_title"].ToString(),
                                Isi = reader["isi_chapter"].ToString(),
                                Urutan = Convert.ToInt32(reader["chapter_number"])
                            };

                            chapters.Add(ch);
                            lstChapter.Items.Add(ch.Judul);
                        }
                    }
                }
            }

            if (chapters.Count > 0)
                ShowChapter(0); // tampilkan chapter pertama
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

        private void SaveHistory(Chapter chapter)
        {
            if (currentMember == null) return;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string checkQuery = "SELECT history_id FROM History WHERE member_id=@member AND buku_id=@buku";
                int? historyId = null;

                using (var cmdCheck = new NpgsqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@member", (currentMember.UserID));
                    cmdCheck.Parameters.AddWithValue("@buku", bukuId);

                    var result = cmdCheck.ExecuteScalar();
                    if (result != null)
                        historyId = Convert.ToInt32(result);
                }

                if (historyId.HasValue)
                {
                    string updateQuery = @"
                        UPDATE History 
                        SET chapter_id=@chapter,
                            halaman_terakhir=@hal, 
                            terakhir_dibaca=NOW() 
                        WHERE history_id=@id";
                    using (var cmdUpdate = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@chapter", chapter.Id);
                        cmdUpdate.Parameters.AddWithValue("@hal", chapter.Urutan);
                        cmdUpdate.Parameters.AddWithValue("@id", historyId.Value);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insertQuery = @"
                        INSERT INTO History(member_id, buku_id, chapter_id, halaman_terakhir, terakhir_dibaca)
                        VALUES(@member, @buku, @chapter, @hal, NOW())";
                    using (var cmdInsert = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@member", (currentMember.UserID));
                        cmdInsert.Parameters.AddWithValue("@buku", bukuId);
                        cmdInsert.Parameters.AddWithValue("@chapter", chapter.Id);
                        cmdInsert.Parameters.AddWithValue("@hal", chapter.Urutan);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
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
    public class Chapter
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Isi { get; set; }
        public int Urutan { get; set; }
    }
}