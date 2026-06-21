using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace projekpbobismillah.models
{
    public class History
    {
        public int UserID { get; set; }
        public string BookID { get; set; }
        public Book Book { get; set; }
        public int LastPage { get; set; }
        public DateTime LastReadAt { get; set; }

        public History(int userID, Book book)
        {
            UserID = userID;
            Book = book;
            BookID = book.IDBuku;
            LastPage = 0;
            LastReadAt = DateTime.Now;
        }

        public static DataTable AmbilRiwayatOlehMember(int memberId)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        h.history_id, 
                        h.buku_id, 
                        h.halaman_terakhir, 
                        h.terakhir_dibaca, 
                        b.judul, 
                        b.penulis
                    FROM public.history h
                    JOIN public.buku b ON b.buku_id = h.buku_id
                    WHERE h.member_id = @memberId
                    ORDER BY h.terakhir_dibaca DESC;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public void SaveProgress(int page)
        {
            LastPage = page;
            LastReadAt = DateTime.Now;
            Console.WriteLine($"User {UserID} membaca '{Book.Judul}' sampai halaman {page}");
        }
    }
}