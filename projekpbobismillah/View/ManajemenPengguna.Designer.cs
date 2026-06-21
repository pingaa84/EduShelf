namespace projekpbobismillah.form
{
    partial class ManajemenPengguna
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManajemenBuku = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.btnKelolaAkun = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(12, 106);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 38);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManajemenBuku
            // 
            this.btnManajemenBuku.BackColor = System.Drawing.Color.Transparent;
            this.btnManajemenBuku.FlatAppearance.BorderSize = 0;
            this.btnManajemenBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenBuku.Location = new System.Drawing.Point(12, 163);
            this.btnManajemenBuku.Name = "btnManajemenBuku";
            this.btnManajemenBuku.Size = new System.Drawing.Size(228, 38);
            this.btnManajemenBuku.TabIndex = 1;
            this.btnManajemenBuku.UseVisualStyleBackColor = false;
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.Transparent;
            this.btnSubscription.FlatAppearance.BorderSize = 0;
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Location = new System.Drawing.Point(12, 219);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(228, 38);
            this.btnSubscription.TabIndex = 2;
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.BackgroundColor = System.Drawing.Color.White;
            this.dgvMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMember.Location = new System.Drawing.Point(290, 125);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.Size = new System.Drawing.Size(1018, 531);
            this.dgvMember.TabIndex = 3;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // btnKelolaAkun
            // 
            this.btnKelolaAkun.BackColor = System.Drawing.Color.Transparent;
            this.btnKelolaAkun.BorderRadius = 8;
            this.btnKelolaAkun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKelolaAkun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKelolaAkun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKelolaAkun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKelolaAkun.FillColor = System.Drawing.Color.Transparent;
            this.btnKelolaAkun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKelolaAkun.ForeColor = System.Drawing.Color.White;
            this.btnKelolaAkun.Location = new System.Drawing.Point(12, 622);
            this.btnKelolaAkun.Name = "btnKelolaAkun";
            this.btnKelolaAkun.Size = new System.Drawing.Size(226, 60);
            this.btnKelolaAkun.TabIndex = 9;
            this.btnKelolaAkun.Click += new System.EventHandler(this.btnKelolaAkun_Click);
            // 
            // ManajemenPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_manajemen_pengguna;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.btnKelolaAkun);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.btnSubscription);
            this.Controls.Add(this.btnManajemenBuku);
            this.Controls.Add(this.btnDashboard);
            this.Name = "ManajemenPengguna";
            this.Text = "ManajemenPengguna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManajemenPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManajemenBuku;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.DataGridView dgvMember;
        private Guna.UI2.WinForms.Guna2Button btnKelolaAkun;
    }
}