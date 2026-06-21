using Npgsql;
using System;
using System.Data;

namespace projekpbobismillah.models
{
    public class Subscription
    {
        public string SubscriptionID { get; set; } // Diubah jadi string agar pas dengan Ticks string di Member.cs
        public int MemberID { get; set; }
        public string Plan { get; set; }
        public decimal Harga { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        private static string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

        public Subscription() { }

        public Subscription(string subID, string plan, decimal harga)
        {
            SubscriptionID = subID;
            Plan = plan;
            Harga = harga;
            Status = "aktif";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(30);
        }

        public bool IsActive()
        {
            return Status != null && Status.ToLower() == "active" && EndDate > DateTime.Now;
        }

        public void Perpanjang()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(30);
            Status = "active";
        }

        public void Cancel()
        {
            Status = "cancelled";
        }

        public static bool ProsesPembayaranPremium(int memberId, string metodeBayar, decimal harga)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string querySub = @"
                UPDATE Subscription 
                SET status = 'aktif', 
                    start_date = NOW(), 
                    end_date = NOW() + INTERVAL '30 days',
                    harga = @harga
                WHERE member_id = @memberId 
                  AND LOWER(status) = 'pending';";

                    int rowsAffected = 0;
                    using (var cmd = new NpgsqlCommand(querySub, conn))
                    {
                        cmd.Parameters.AddWithValue("memberId", memberId);
                        cmd.Parameters.AddWithValue("harga", harga);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                    if (rowsAffected == 0)
                    {
                        string backupQuery = @"
                            INSERT INTO Subscription (member_id, plan, harga, start_date, end_date, status)
                            VALUES (@memberId, 'Premium', @harga, NOW(), NOW() + INTERVAL '30 days', 'aktif')";

                        using (var backupCmd = new NpgsqlCommand(backupQuery, conn))
                        {
                            backupCmd.Parameters.AddWithValue("memberId", memberId);
                            backupCmd.Parameters.AddWithValue("harga", harga);
                            backupCmd.ExecuteNonQuery();
                        }
                    }
                    string queryTransaksi = @"
                        INSERT INTO Transaksi (member_id, tipe, deskripsi, harga, status, tgl_transaksi, metode_pembayaran)
                        VALUES (@memberId, 'Pembayaran', 'Langganan Premium 30 Hari', @harga, 'berhasil', NOW(), @metode);";

                    using (var cmdTrans = new NpgsqlCommand(queryTransaksi, conn))
                    {
                        cmdTrans.Parameters.AddWithValue("memberId", memberId);
                        cmdTrans.Parameters.AddWithValue("harga", harga);
                        cmdTrans.Parameters.AddWithValue("metode", metodeBayar);
                        cmdTrans.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable AmbilSemuaSubscription()
        {
            DataTable dt = new DataTable();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        s.subscription_id, s.member_id,
                        (m.nama_depan || ' ' || m.nama_belakang) AS nama_member,
                        s.plan, s.harga, s.start_date, s.end_date, s.status
                    FROM Subscription s
                    JOIN Member m ON s.member_id = m.member_id
                    ORDER BY s.subscription_id DESC;";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static void UpdateStatusSubscription(int subId, string statusBaru)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    UPDATE Subscription 
                    SET status = @status, start_date = NOW(), end_date = NOW() + INTERVAL '30 days'
                    WHERE subscription_id = @id;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("status", statusBaru);
                    cmd.Parameters.AddWithValue("id", subId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}