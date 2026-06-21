namespace projekpbobismillah.form
{
    partial class KelolaAkunAdmin
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
            this.dgvAkunadmin = new System.Windows.Forms.DataGridView();
            this.btnTambahakun = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManajemen = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkunadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAkunadmin
            // 
            this.dgvAkunadmin.AllowUserToAddRows = false;
            this.dgvAkunadmin.AllowUserToDeleteRows = false;
            this.dgvAkunadmin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAkunadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAkunadmin.Location = new System.Drawing.Point(279, 183);
            this.dgvAkunadmin.Name = "dgvAkunadmin";
            this.dgvAkunadmin.ReadOnly = true;
            this.dgvAkunadmin.Size = new System.Drawing.Size(1044, 490);
            this.dgvAkunadmin.TabIndex = 0;
            this.dgvAkunadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAkunadmin_CellContentClick);
            // 
            // btnTambahakun
            // 
            this.btnTambahakun.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahakun.FlatAppearance.BorderSize = 0;
            this.btnTambahakun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahakun.Location = new System.Drawing.Point(1147, 101);
            this.btnTambahakun.Name = "btnTambahakun";
            this.btnTambahakun.Size = new System.Drawing.Size(190, 40);
            this.btnTambahakun.TabIndex = 1;
            this.btnTambahakun.UseVisualStyleBackColor = false;
            this.btnTambahakun.Click += new System.EventHandler(this.btnTambahakun_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(21, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(219, 55);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManajemen
            // 
            this.btnManajemen.BackColor = System.Drawing.Color.Transparent;
            this.btnManajemen.FlatAppearance.BorderSize = 0;
            this.btnManajemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemen.Location = new System.Drawing.Point(21, 135);
            this.btnManajemen.Name = "btnManajemen";
            this.btnManajemen.Size = new System.Drawing.Size(219, 55);
            this.btnManajemen.TabIndex = 3;
            this.btnManajemen.UseVisualStyleBackColor = false;
            this.btnManajemen.Click += new System.EventHandler(this.btnManajemen_Click);
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.Transparent;
            this.btnSubscription.FlatAppearance.BorderSize = 0;
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Location = new System.Drawing.Point(21, 184);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(219, 55);
            this.btnSubscription.TabIndex = 4;
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.Transparent;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Location = new System.Drawing.Point(21, 236);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(219, 55);
            this.btnMember.TabIndex = 5;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // KelolaAkunAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_kelola_admin;
            this.ClientSize = new System.Drawing.Size(1350, 707);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnSubscription);
            this.Controls.Add(this.btnManajemen);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnTambahakun);
            this.Controls.Add(this.dgvAkunadmin);
            this.Name = "KelolaAkunAdmin";
            this.Text = "KelolaAkunAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KelolaAkunAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkunadmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAkunadmin;
        private System.Windows.Forms.Button btnTambahakun;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManajemen;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Button btnMember;
    }
}