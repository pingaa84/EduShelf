using projekpbobismillah.form;
using projekpbobismillah.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekpbobismillah.Controllers
{
    public class PaymentController
    {
        private Form _formPembayaran;

        public PaymentController(Form formPembayaran)
        {
            _formPembayaran = formPembayaran;
        }

        public void EksekusiPembayaran(Member member, string metodeBayar)
        {
            string plan = "Premium";
            decimal harga = 100000;

            if (metodeBayar == "Unknown")
            {
                MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool sukses = Subscription.ProsesPembayaranPremium(member.UserID, metodeBayar, harga);

                if (sukses)
                { 
                    member.Subscribe(plan, harga);

                    MessageBox.Show($"Pembayaran {metodeBayar} berhasil!\nAkun sekarang ACTIVE.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MemberDashboard dash = new MemberDashboard(member);
                    dash.Show();
                    _formPembayaran.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal memproses pembayaran. Data langganan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
