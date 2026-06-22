using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.models
{
    public class Admin : User
    {
        public List<Member> MemberList { get; set; } = new List<Member>();
        public List<Book> BookList { get; set; } = new List<Book>();

        public Admin(int userID, string email, string password)
            : base(userID, email, password)
        { }

        public static Admin ValidasiLoginAdmin(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string queryAdmin = @"
                    SELECT admin_id, email, password
                    FROM Admin
                    WHERE email = @Email AND password = @Password
                ";

                using (var cmdAdmin = new NpgsqlCommand(queryAdmin, conn))
                {
                    cmdAdmin.Parameters.AddWithValue("Email", email);
                    cmdAdmin.Parameters.AddWithValue("Password", password);

                    using (var reader = cmdAdmin.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int adminId = Convert.ToInt32(reader["admin_id"]);
                            string adminEmail = reader["email"].ToString();
                            string adminPassword = reader["password"].ToString();
                            return new Admin(adminId, adminEmail, adminPassword);
                        }
                    }
                }
            }
            return null;
        }
        private static string dbConnString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public override void ViewDashboard()
        {
            Console.WriteLine($"Admin {Email} melihat semua daftar buku.");
        }

        public void AddBook(string bookTitle)
        {
            Console.WriteLine($"Admin {Email} menambahkan buku: {bookTitle}");
        }

        public void EditBook(string bookId, string newTitle, string newAuthor)
        {
            var book = BookList.Find(b => b.IDBuku == bookId);
            if (book != null)
            {
                book.Judul = newTitle;
                book.Author = newAuthor;
                Console.WriteLine($"Buku '{bookId}' diperbarui menjadi '{newTitle}'");
            }
            else
            {
                Console.WriteLine($"Buku dengan ID '{bookId}' tidak ditemukan");
            }
        }

        public void RemoveBook(string bookTitle)
        {
            Console.WriteLine($"Admin {Email} menghapus buku: {bookTitle}");
        }

        public void ViewMembers()
        {
            Console.WriteLine("Daftar Member:");
            if (MemberList == null || MemberList.Count == 0)
            {
                Console.WriteLine("Belum ada member yang terdaftar.");
                return;
            }

            foreach (var m in MemberList)
            {
               
                string statusMember = (m.LanggananAktif != null) ? "Active" : "Free";
                Console.WriteLine($"- Email: {m.Email,-30} | Status: {statusMember}");
            }
        }
    }
    
}

