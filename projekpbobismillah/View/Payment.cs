using System;
using System.Windows.Forms;
using projekpbobismillah.models;
using projekpbobismillah.Controllers; 

namespace projekpbobismillah.form
{
    public partial class Payment : Form
    {
        private Member currentMember;
        private PaymentController _paymentController;

        public Payment(Member member)
        {
            InitializeComponent();
            currentMember = member;
            _paymentController = new PaymentController(this);

            rbGopay.Checked = true;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string metodeBayar = GetMetode();

            _paymentController.EksekusiPembayaran(currentMember, metodeBayar);
        }

        private string GetMetode()
        {
            if (rbGopay.Checked) return "GoPay";
            if (rbOvo.Checked) return "OVO";
            if (rbDana.Checked) return "Dana";
            if (rbTransfer.Checked) return "Transfer Bank";

            return "Unknown";
        }

        private void rbGopay_CheckedChanged(object sender, EventArgs e) { }
        private void rbOvo_CheckedChanged(object sender, EventArgs e) { }
        private void rbDana_CheckedChanged(object sender, EventArgs e) { }
        private void rbTransfer_CheckedChanged(object sender, EventArgs e) { }
    }
}