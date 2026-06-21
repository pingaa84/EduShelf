using Npgsql;
using System;
using System.Data;

namespace projekpbobismillah.models
{
    public class Chapter
    {
        public int ChapterID { get; set; }
        public int BukuID { get; set; }
        public int ChapterNumber { get; set; }
        public string ChapterTitle { get; set; }
        public string IsiChapter { get; set; }

        private static string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public static DataTable AmbilChapterByBuku(int bukuId)
        {
            DataTable dt = new DataTable();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT chapter_id, chapter_number, chapter_title, isi_chapter
                    FROM Chapter
                    WHERE buku_id = @id
                    ORDER BY chapter_number ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", bukuId);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static void TambahChapter(int bukuId, int number, string title, string isi)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Chapter (buku_id, chapter_number, chapter_title, isi_chapter, created_at)
                    VALUES (@buku_id, @no, @title, @isi, NOW())";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("buku_id", bukuId);
                    cmd.Parameters.AddWithValue("no", number);
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("isi", isi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateChapter(int chapterId, int number, string title, string isi)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    UPDATE Chapter
                    SET chapter_number = @no,
                        chapter_title = @title,
                        isi_chapter = @isi,
                        updated_at = NOW()
                    WHERE chapter_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("no", number);
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("isi", isi);
                    cmd.Parameters.AddWithValue("id", chapterId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void HapusChapter(int chapterId)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM Chapter WHERE chapter_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", chapterId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}