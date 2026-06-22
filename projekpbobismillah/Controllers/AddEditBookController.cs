using Npgsql;
using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class AddEditBookController
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public DataTable DapatkanKategori()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT kategori_id, nama_kategori FROM Kategori";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public int SimpanBuku(Book book, int kategoriId)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                if (string.IsNullOrEmpty(book.IDBuku))
                {
                    string queryInsert = @"
                        INSERT INTO Buku 
                        (judul, penulis, cover, kategori_id, updated_at)
                        VALUES 
                        (@judul, @penulis, @cover, @kategori, NOW())
                        RETURNING buku_id;
                    ";

                    using (var cmd = new NpgsqlCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@judul", book.Judul);
                        cmd.Parameters.AddWithValue("@penulis", book.Author);
                        cmd.Parameters.AddWithValue("@cover", book.Cover ?? "");
                        cmd.Parameters.AddWithValue("@kategori", kategoriId);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                else
                {
                    string queryUpdate = @"
                        UPDATE Buku 
                        SET judul=@judul,
                            penulis=@penulis,
                            cover=@cover,
                            kategori_id=@kategori,
                            updated_at=NOW()
                        WHERE buku_id=@id;
                    ";

                    using (var cmd = new NpgsqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@judul", book.Judul);
                        cmd.Parameters.AddWithValue("@penulis", book.Author);
                        cmd.Parameters.AddWithValue("@cover", book.Cover ?? "");
                        cmd.Parameters.AddWithValue("@kategori", kategoriId);
                        cmd.Parameters.AddWithValue("@id", int.Parse(book.IDBuku));

                        cmd.ExecuteNonQuery();

                        return int.Parse(book.IDBuku);
                    }
                }
            }
        }
    }
}
