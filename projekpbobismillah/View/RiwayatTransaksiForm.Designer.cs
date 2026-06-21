namespace projekpbobismillah.form
{
    partial class RiwayatTransaksiForm
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
            this.dgvRiwayatTransaksi = new System.Windows.Forms.DataGridView();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRiwayatTransaksi
            // 
            this.dgvRiwayatTransaksi.AllowUserToAddRows = false;
            this.dgvRiwayatTransaksi.AllowUserToDeleteRows = false;
            this.dgvRiwayatTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayatTransaksi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRiwayatTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayatTransaksi.Location = new System.Drawing.Point(261, 303);
            this.dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            this.dgvRiwayatTransaksi.ReadOnly = true;
            this.dgvRiwayatTransaksi.Size = new System.Drawing.Size(1077, 423);
            this.dgvRiwayatTransaksi.TabIndex = 0;
            this.dgvRiwayatTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiwayatTransaksi_CellContentClick);
            // 
            // btnBeranda
            // 
            this.btnBeranda.BackColor = System.Drawing.Color.Transparent;
            this.btnBeranda.FlatAppearance.BorderSize = 0;
            this.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeranda.Location = new System.Drawing.Point(12, 93);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new System.Drawing.Size(192, 41);
            this.btnBeranda.TabIndex = 1;
            this.btnBeranda.UseVisualStyleBackColor = false;
            this.btnBeranda.Click += new System.EventHandler(this.btnBeranda_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(12, 140);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(192, 41);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Location = new System.Drawing.Point(12, 248);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(192, 41);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.button3_Click);
            // 
            // RiwayatTransaksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halamanriwayattransaksi;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBeranda);
            this.Controls.Add(this.dgvRiwayatTransaksi);
            this.Name = "RiwayatTransaksiForm";
            this.Text = "RiwayatTransaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RiwayatTransaksiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayatTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiwayatTransaksi;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfil;
    }
}