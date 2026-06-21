using projekpbobismillah.models;
using projekpbobismillah.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projekpbobismillah.form
{
    public partial class MemberDashboard : Form
    {
        public Member currentMember;

        private DashboardController _dashboardController;

        public MemberDashboard(Member member)
        {
            InitializeComponent();
            currentMember = member;
            _dashboardController = new DashboardController();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            RenderBukuKeDashboard(_dashboardController.MuatBuku());
            SetupSearchTextBox();
        }
        private void RenderBukuKeDashboard(List<Book> daftarBuku)
        {
            flowLayoutPanelBooks.Controls.Clear();
            foreach (var book in daftarBuku)
            {
                AddBookCardToMember(book);
            }
        }

        private void AddBookCardToMember(Book book)
        {
            Panel card = new Panel();
            card.Size = new Size(150, 230);
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Tag = book.IDBuku;

            PictureBox cover = new PictureBox();
            cover.Size = new Size(130, 140);
            cover.Location = new Point(10, 10);
            cover.SizeMode = PictureBoxSizeMode.Zoom;

            if (!string.IsNullOrEmpty(book.Cover) && File.Exists(book.Cover))
            {
                cover.Image = Image.FromFile(book.Cover);
            }
            else
            {
                cover.BackColor = Color.LightGray;
            }

            Label title = new Label();
            title.Text = book.Judul;
            title.Location = new Point(10, 155);
            title.AutoSize = true;
            title.Font = new Font("Arial", 9, FontStyle.Bold);

            Label author = new Label();
            author.Text = book.Author;
            author.Location = new Point(10, 175);
            author.ForeColor = Color.Gray;
            author.AutoSize = true;

            card.Controls.Add(cover);
            card.Controls.Add(title);
            card.Controls.Add(author);

            card.Click += (s, e) => OpenReader(book);
            cover.Click += (s, e) => OpenReader(book);
            title.Click += (s, e) => OpenReader(book);
            author.Click += (s, e) => OpenReader(book);

            flowLayoutPanelBooks.Controls.Add(card);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            List<Book> hasilFilter = _dashboardController.CariBuku(txtCari.Text);

            RenderBukuKeDashboard(hasilFilter);
        }

        private void SetupSearchTextBox()
        {
            txtCari.Text = "Cari buku...";
            txtCari.ForeColor = Color.Gray;

            txtCari.GotFocus += (s, e) =>
            {
                if (txtCari.Text == "Cari buku...")
                {
                    txtCari.Text = "";
                    txtCari.ForeColor = Color.Black;
                }
            };

            txtCari.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    txtCari.Text = "Cari buku...";
                    txtCari.ForeColor = Color.Gray;
                }
            };

            txtCari.TextChanged += txtCari_TextChanged;
        }

        private void OpenReader(Book book)
        {
            halamanbaca reader = new halamanbaca(Convert.ToInt32(book.IDBuku), currentMember, 1);
            reader.Show();
            this.Hide();
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(currentMember);
            form.Show();
            this.Hide();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            RiwayatTransaksiForm form = new RiwayatTransaksiForm(currentMember);
            form.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            ProfilMember profil = new ProfilMember(currentMember);
            profil.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}