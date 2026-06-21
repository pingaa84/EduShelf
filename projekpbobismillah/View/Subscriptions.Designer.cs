namespace projekpbobismillah.form
{
    partial class Subscriptions
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
            this.btnMAnajemenBuku = new System.Windows.Forms.Button();
            this.btnManajemenMemb = new System.Windows.Forms.Button();
            this.dgvSubscription = new System.Windows.Forms.DataGridView();
            this.btnKelolaAkun = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(23, 109);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(197, 37);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMAnajemenBuku
            // 
            this.btnMAnajemenBuku.BackColor = System.Drawing.Color.Transparent;
            this.btnMAnajemenBuku.FlatAppearance.BorderSize = 0;
            this.btnMAnajemenBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAnajemenBuku.Location = new System.Drawing.Point(23, 165);
            this.btnMAnajemenBuku.Name = "btnMAnajemenBuku";
            this.btnMAnajemenBuku.Size = new System.Drawing.Size(197, 37);
            this.btnMAnajemenBuku.TabIndex = 1;
            this.btnMAnajemenBuku.UseVisualStyleBackColor = false;
            this.btnMAnajemenBuku.Click += new System.EventHandler(this.btnMAnajemenBuku_Click_1);
            // 
            // btnManajemenMemb
            // 
            this.btnManajemenMemb.BackColor = System.Drawing.Color.Transparent;
            this.btnManajemenMemb.FlatAppearance.BorderSize = 0;
            this.btnManajemenMemb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenMemb.Location = new System.Drawing.Point(23, 276);
            this.btnManajemenMemb.Name = "btnManajemenMemb";
            this.btnManajemenMemb.Size = new System.Drawing.Size(197, 37);
            this.btnManajemenMemb.TabIndex = 2;
            this.btnManajemenMemb.UseVisualStyleBackColor = false;
            this.btnManajemenMemb.Click += new System.EventHandler(this.btnManajemenMemb_Click);
            // 
            // dgvSubscription
            // 
            this.dgvSubscription.AllowUserToAddRows = false;
            this.dgvSubscription.AllowUserToDeleteRows = false;
            this.dgvSubscription.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscription.Location = new System.Drawing.Point(269, 158);
            this.dgvSubscription.Name = "dgvSubscription";
            this.dgvSubscription.ReadOnly = true;
            this.dgvSubscription.Size = new System.Drawing.Size(1035, 526);
            this.dgvSubscription.TabIndex = 3;
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
            this.btnKelolaAkun.Location = new System.Drawing.Point(12, 631);
            this.btnKelolaAkun.Name = "btnKelolaAkun";
            this.btnKelolaAkun.Size = new System.Drawing.Size(226, 60);
            this.btnKelolaAkun.TabIndex = 8;
            this.btnKelolaAkun.Click += new System.EventHandler(this.btnKelolaAkun_Click);
            // 
            // Subscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_subs;
            this.ClientSize = new System.Drawing.Size(1334, 710);
            this.Controls.Add(this.btnKelolaAkun);
            this.Controls.Add(this.dgvSubscription);
            this.Controls.Add(this.btnManajemenMemb);
            this.Controls.Add(this.btnMAnajemenBuku);
            this.Controls.Add(this.btnDashboard);
            this.Name = "Subscriptions";
            this.Text = "Subscriptions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Subscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMAnajemenBuku;
        private System.Windows.Forms.Button btnManajemenMemb;
        private System.Windows.Forms.DataGridView dgvSubscription;
        private Guna.UI2.WinForms.Guna2Button btnKelolaAkun;
    }
}