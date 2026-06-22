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
    public class DashboardAdminController
    {
        private string connString =
            "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public string DapatkanTotalBuku()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Buku", conn))
                {
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public DataTable DapatkanGrafikPremium()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        TO_CHAR(start_date, 'Mon') AS bulan,
                        COUNT(*) AS total
                    FROM Subscription
                    WHERE LOWER(status) = 'active'
                    GROUP BY TO_CHAR(start_date, 'Mon'), EXTRACT(MONTH FROM start_date)
                    ORDER BY EXTRACT(MONTH FROM start_date) ASC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable DapatkanGrafikTotalMember()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        TO_CHAR(created_at, 'Mon') AS bulan,
                        COUNT(*) AS total
                    FROM Member
                    GROUP BY TO_CHAR(created_at, 'Mon'), EXTRACT(MONTH FROM created_at)
                    ORDER BY EXTRACT(MONTH FROM created_at) ASC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable DapatkanGrafikRevenue()
        {
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        TO_CHAR(tgl_transaksi, 'Mon') AS bulan,
                        COALESCE(SUM(harga), 0) AS total
                    FROM Transaksi
                    WHERE LOWER(status) = 'berhasil'
                    GROUP BY TO_CHAR(tgl_transaksi, 'Mon'), EXTRACT(MONTH FROM tgl_transaksi)
                    ORDER BY EXTRACT(MONTH FROM tgl_transaksi) ASC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
