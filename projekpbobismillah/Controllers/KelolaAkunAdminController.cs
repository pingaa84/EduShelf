using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
    public class KelolaAkunAdminController
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public DataTable DapatkanDaftarAdmin()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT admin_id, nama, email FROM Admin ORDER BY admin_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public void HapusAdmin(int adminId)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "DELETE FROM Admin WHERE admin_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", adminId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void TambahAdmin(string email, string password)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string queryHitung = "SELECT COUNT(*) FROM Admin";
                int totalAdminSekarang = 0;

                using (var cmdHitung = new NpgsqlCommand(queryHitung, conn))
                {
                    totalAdminSekarang = Convert.ToInt32(cmdHitung.ExecuteScalar());
                }

                int nomorAdminBaru = totalAdminSekarang + 1;
                string namaOtomatis = "Admin " + nomorAdminBaru;

                string queryInsert = @"
                    INSERT INTO Admin(email, password, nama) 
                    VALUES(@Email, @Password, @Nama)
                ";

                using (var cmdInsert = new NpgsqlCommand(queryInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("Email", email);
                    cmdInsert.Parameters.AddWithValue("Password", password);
                    cmdInsert.Parameters.AddWithValue("Nama", namaOtomatis);

                    cmdInsert.ExecuteNonQuery();
                }
            }
        }
    }
}
