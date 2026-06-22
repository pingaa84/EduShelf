using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace projekpbobismillah.Controllers
{

    public class HalamanBacaController
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public string DapatkanJudulBuku(int bukuId)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT judul FROM Buku WHERE buku_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bukuId);

                    var result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : "";
                }
            }
        }

        public List<ChapterBaca> DapatkanChapterBuku(int bukuId)
        {
            List<ChapterBaca> daftarChapter = new List<ChapterBaca>();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT chapter_id, chapter_title, isi_chapter, chapter_number
                    FROM Chapter
                    WHERE buku_id=@id
                    ORDER BY chapter_number ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bukuId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChapterBaca chapter = new ChapterBaca
                            {
                                Id = Convert.ToInt32(reader["chapter_id"]),
                                Judul = reader["chapter_title"].ToString(),
                                Isi = reader["isi_chapter"].ToString(),
                                Urutan = Convert.ToInt32(reader["chapter_number"])
                            };

                            daftarChapter.Add(chapter);
                        }
                    }
                }
            }

            return daftarChapter;
        }

        public void SimpanHistoryBaca(int memberId, int bukuId, ChapterBaca chapter)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string checkQuery = "SELECT history_id FROM History WHERE member_id=@member AND buku_id=@buku";
                int? historyId = null;

                using (var cmdCheck = new NpgsqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@member", memberId);
                    cmdCheck.Parameters.AddWithValue("@buku", bukuId);

                    var result = cmdCheck.ExecuteScalar();

                    if (result != null)
                    {
                        historyId = Convert.ToInt32(result);
                    }
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
                        cmdInsert.Parameters.AddWithValue("@member", memberId);
                        cmdInsert.Parameters.AddWithValue("@buku", bukuId);
                        cmdInsert.Parameters.AddWithValue("@chapter", chapter.Id);
                        cmdInsert.Parameters.AddWithValue("@hal", chapter.Urutan);

                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    public class ChapterBaca
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Isi { get; set; }
        public int Urutan { get; set; }
    }

}
