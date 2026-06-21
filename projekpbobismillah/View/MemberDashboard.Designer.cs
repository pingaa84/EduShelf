namespace projekpbobismillah.form
{
    partial class MemberDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRiwayatTransaksi = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.panelBookContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBookContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(12, 173);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 37);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRiwayatTransaksi
            // 
            this.btnRiwayatTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btnRiwayatTransaksi.FlatAppearance.BorderSize = 0;
            this.btnRiwayatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayatTransaksi.Location = new System.Drawing.Point(12, 227);
            this.btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            this.btnRiwayatTransaksi.Size = new System.Drawing.Size(200, 37);
            this.btnRiwayatTransaksi.TabIndex = 1;
            this.btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            this.btnRiwayatTransaksi.Click += new System.EventHandler(this.btnRiwayatTransaksi_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Location = new System.Drawing.Point(12, 281);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(200, 37);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // panelBookContainer
            // 
            this.panelBookContainer.AutoScroll = true;
            this.panelBookContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelBookContainer.Controls.Add(this.flowLayoutPanelBooks);
            this.panelBookContainer.Location = new System.Drawing.Point(266, 186);
            this.panelBookContainer.Name = "panelBookContainer";
            this.panelBookContainer.Size = new System.Drawing.Size(1048, 519);
            this.panelBookContainer.TabIndex = 4;
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(1048, 519);
            this.flowLayoutPanelBooks.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 648);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.SystemColors.Control;
            this.txtCari.BorderRadius = 8;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "Cari Buku";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(597, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(448, 41);
            this.txtCari.TabIndex = 6;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_dashboard_member;
            this.ClientSize = new System.Drawing.Size(1350, 721);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelBookContainer);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnRiwayatTransaksi);
            this.Controls.Add(this.btnHistory);
            this.Name = "MemberDashboard";
            this.Text = "MemberDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            this.panelBookContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Panel panelBookContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
    }
}