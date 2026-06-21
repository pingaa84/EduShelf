using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace projekpbobismillah.models
{
    public class RiwayatTransaksi
    {
        public string TransactionID { get; set; }
        public string UserID { get; set; }
        public string Plan { get; set; }
        public decimal Harga { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }

        public RiwayatTransaksi(string transactionID, string userID, string plan, decimal harga, string status)
        {
            TransactionID = transactionID;
            UserID = userID;
            Plan = plan;
            Harga = harga;
            TransactionDate = DateTime.Now;
            Status = status;
        }
        public static DataTable AmbilTransaksiOlehMember(int memberId)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        t.transaksi_id,
                        t.tipe,
                        t.deskripsi,
                        t.harga,
                        t.status AS status_transaksi,
                        t.tgl_transaksi,
                        t.metode_pembayaran,
                        dt.status AS status_detail
                    FROM Transaksi t
                    LEFT JOIN DetailTransaksi dt 
                        ON t.transaksi_id = dt.transaksi_id
                    WHERE t.member_id = @member_id
                    ORDER BY t.tgl_transaksi DESC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("member_id", memberId);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static List<RiwayatTransaksi> AllTransactions { get; set; } = new List<RiwayatTransaksi>();

        public static void TambahTransaction(RiwayatTransaksi transaksi)
        {
            AllTransactions.Add(transaksi);
            Console.WriteLine($"Transaksi {transaksi.Plan} untuk user {transaksi.UserID} tersimpan dengan status {transaksi.Status}");
        }

        public static List<RiwayatTransaksi> Transaksibyuser(string userID)
        {
            return AllTransactions.FindAll(t => t.UserID == userID);
        }

        public static string GetLastTransactionStatus(string userID)
        {
            var list = Transaksibyuser(userID);
            if (list.Count == 0) return "Belum ada transaksi";
            return list[list.Count - 1].Status;
        }
    }
}