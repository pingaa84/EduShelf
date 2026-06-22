using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekpbobismillah.Controllers
{
        public class ProfilMemberController
        {
            private string connString =
                "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

            public DataTable DapatkanProfilMember(int memberId)
            {
                DataTable dt = new DataTable();

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Member WHERE member_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", memberId);

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                return dt;
            }

            public bool SimpanProfilMember(
                int memberId,
                string namaDepan,
                string namaBelakang,
                string email,
                string noTelepon,
                string bio,
                string fotoPath)
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                    UPDATE Member 
                    SET nama_depan=@namaDepan,
                        nama_belakang=@namaBelakang,
                        email=@email,
                        no_telepon=@telp,
                        bio=@bio,
                        foto_profil=@foto
                    WHERE member_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@namaDepan", namaDepan);
                        cmd.Parameters.AddWithValue("@namaBelakang", namaBelakang);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telp", noTelepon);
                        cmd.Parameters.AddWithValue("@bio", bio);
                        cmd.Parameters.AddWithValue("@foto", fotoPath ?? "");
                        cmd.Parameters.AddWithValue("@id", memberId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
        }
    
}
