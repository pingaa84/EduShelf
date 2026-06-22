using Npgsql;
using System;
using System.Collections.Generic;

namespace projekpbobismillah.models
{
    public class Book
    {
        public string IDBuku { get; set; }
        public string Judul { get; set; }
        public string Author { get; set; }
        public string Cover { get; set; }
        public int IDCategory { get; set; }

        public static List<Book> AmbilSemuaBuku()
        {
            List<Book> daftarBuku = new List<Book>();
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
            SELECT 
                buku_id,
                judul,
                penulis,
                cover,
                COALESCE(kategori_id, 0) AS kategori_id
            FROM Buku
            ORDER BY buku_id DESC;
        ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            IDBuku = reader["buku_id"].ToString(),
                            Judul = reader["judul"].ToString(),
                            Author = reader["penulis"].ToString(),
                            Cover = reader["cover"].ToString(),
                            IDCategory = Convert.ToInt32(reader["kategori_id"])
                        };

                        daftarBuku.Add(book);
                    }
                }
            }

            return daftarBuku;
        }
        public static void TambahBuku(Book book)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Buku (judul, penulis, cover, updated_at)
                    VALUES (@judul, @penulis, @cover, NOW());";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("judul", book.Judul);
                    cmd.Parameters.AddWithValue("penulis", book.Author);
                    cmd.Parameters.AddWithValue("cover", book.Cover ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UbahBuku(Book book)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    UPDATE Buku
                    SET judul = @judul,
                        penulis = @penulis,
                        cover = @cover,
                        updated_at = NOW()
                    WHERE buku_id = @id;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(book.IDBuku));
                    cmd.Parameters.AddWithValue("judul", book.Judul);
                    cmd.Parameters.AddWithValue("penulis", book.Author);
                    cmd.Parameters.AddWithValue("cover", book.Cover ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void HapusBuku(string id)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int bukuId = int.Parse(id);

                        string queryHistory = "DELETE FROM public.history WHERE buku_id = @id";
                        using (var cmdHistory = new NpgsqlCommand(queryHistory, conn))
                        {
                            cmdHistory.Transaction = transaction;
                            cmdHistory.Parameters.AddWithValue("id", bukuId);
                            cmdHistory.ExecuteNonQuery();
                        }

                        string queryChapter = "DELETE FROM Chapter WHERE buku_id = @id";
                        using (var cmdChapter = new NpgsqlCommand(queryChapter, conn))
                        {
                            cmdChapter.Transaction = transaction;
                            cmdChapter.Parameters.AddWithValue("id", bukuId);
                            cmdChapter.ExecuteNonQuery();
                        }

                        string queryBuku = "DELETE FROM Buku WHERE buku_id = @id";
                        using (var cmdBuku = new NpgsqlCommand(queryBuku, conn))
                        {
                            cmdBuku.Transaction = transaction;
                            cmdBuku.Parameters.AddWithValue("id", bukuId);
                            cmdBuku.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}