using Npgsql;
using projekpbobismillah.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekpbobismillah.models
{
    public class Member : User, ISubscriptionActions
    {
        
        public string Nama { get; set; }
        public Subscription LanggananAktif { get; set; }
        public List<Book> Bukuyangbisadiakses { get; set; } = new List<Book>();
        public List<History> Histories { get; set; } = new List<History>();
        public List<RiwayatTransaksi> Transaksi { get; set; } = new List<RiwayatTransaksi>();
        public Member(int userID, string email, string password, string nama)
            : base(userID, email, password)
        {
            Nama = nama;
        }
        public static Tuple<Member, string> ValidasiLoginMember(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string queryMember = @"
                SELECT 
                    m.member_id,
                    m.nama_depan,
                    m.nama_belakang,
                    m.email,
                    COALESCE(s.status, 'pending') AS status
                FROM Member m
                LEFT JOIN Subscription s 
                    ON m.member_id = s.member_id
                    AND s.end_date >= CURRENT_DATE
                WHERE m.email=@Email AND m.password=@Password
                ";

                using (var cmdMember = new NpgsqlCommand(queryMember, conn))
                {
                    cmdMember.Parameters.AddWithValue("Email", email);
                    cmdMember.Parameters.AddWithValue("Password", password);

                    using (var reader = cmdMember.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int memberId = Convert.ToInt32(reader["member_id"]);
                            string namaLengkap = reader["nama_depan"].ToString() + " " + reader["nama_belakang"].ToString();
                            string memberPassword = reader["password"].ToString();
                            string statusLangganan = reader["status"].ToString();

                            
                            Member member = new Member(memberId, email, memberPassword, namaLengkap);

                            return new Tuple<Member, string>(member, statusLangganan);
                        }
                    }
                }
            }
            return null; 
        }
        public static System.Data.DataTable AmbilSemuaDaftarMember()
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            System.Data.DataTable dt = new System.Data.DataTable();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
            SELECT 
                m.member_id,
                (m.nama_depan || ' ' || m.nama_belakang) AS nama_member,
                m.email,
                m.no_telepon,
                m.password,
                COALESCE(s.status, '-') AS subscription_status
            FROM Member m
            LEFT JOIN (
                SELECT DISTINCT ON (member_id)
                    member_id,
                    status
                FROM Subscription
                ORDER BY member_id, start_date DESC
            ) s
            ON m.member_id = s.member_id
            ORDER BY m.member_id ASC;
        ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public static int RegistrasiMemberBaru(string namaDepan, string namaBelakang, string email, string password)
        {
            string connString = "Host=localhost;Port=5432;Database=pbofixamin;Username=postgres;Password=safirah74";
            int newMemberId = 0;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string queryMember = @"
                    INSERT INTO Member
                    (nama_depan, nama_belakang, email, password, no_telepon, foto_profil, bio)
                    VALUES
                    (@nama_depan, @nama_belakang, @email, @password, @telp, @foto, @bio)
                    RETURNING member_id;
                ";

                using (var cmd = new NpgsqlCommand(queryMember, conn))
                {
                    cmd.Parameters.AddWithValue("nama_depan", namaDepan);
                    cmd.Parameters.AddWithValue("nama_belakang", namaBelakang);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("telp", "-");
                    cmd.Parameters.AddWithValue("foto", "-");
                    cmd.Parameters.AddWithValue("bio", "-");

                    newMemberId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string querySub = @"
                    INSERT INTO Subscription
                    (member_id, plan, harga, start_date, end_date, status)
                    VALUES
                    (@id, 'Premium', 0, NOW(), NOW() + INTERVAL '30 days', 'pending');
                ";

                using (var subCmd = new NpgsqlCommand(querySub, conn))
                {
                    subCmd.Parameters.AddWithValue("id", newMemberId);
                    subCmd.ExecuteNonQuery();
                }
            }

            return newMemberId; 
        }
    
        public bool HasActiveSubscription()
        {
            return LanggananAktif != null && LanggananAktif.IsActive();
        }

        public override void ViewDashboard()
        {
            Console.WriteLine($"Dashboard Membe");
            if (!HasActiveSubscription())
            {
                Console.WriteLine("Langganan belum aktif. Silakan lakukan pembayaran untuk mengakses buku.");
                return;
            }

            Console.WriteLine("Buku yang bisa diakses:");
            foreach (var b in Bukuyangbisadiakses)
            {
                Console.WriteLine($"- {b.Judul} oleh {b.Author}");
            }
        }

        public void Subscribe(string plan, decimal harga)
        { 
            LanggananAktif = new Subscription("SUB" + DateTime.Now.Ticks, plan, harga);
            Console.WriteLine($"{Email} berlangganan {plan} Rp{harga} dan dapat mengakses semua buku");
        }

        public void ReadBook(string bookId, int page)
        {
            if (!HasActiveSubscription())
            {
                Console.WriteLine("Anda belum melakukan pembayaran. Tidak bisa membaca buku.");
                return;
            }

            var book = Bukuyangbisadiakses.FirstOrDefault(x => x.IDBuku == bookId);
            if (book == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            var history = Histories.FirstOrDefault(h => h.BookID == bookId);
            if (history == null)
            {
                history = new History(UserID, book);
                Histories.Add(history);
            }

            history.SaveProgress(page);
        }

        public void Perpanjang()
        {
            if (LanggananAktif != null)
                LanggananAktif.Perpanjang();
        }

        public void Cancel()
        {
            if (LanggananAktif != null)
            {
                LanggananAktif.Cancel();
                LanggananAktif = null;
                Bukuyangbisadiakses.Clear();
            }
        }
    }
}
