namespace projekpbobismillah.form
{
    partial class HistoryForm
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnRiwayatTransaksi = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(264, 180);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(1079, 533);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(13, 95);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(213, 38);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnRiwayatTransaksi
            // 
            this.btnRiwayatTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btnRiwayatTransaksi.FlatAppearance.BorderSize = 0;
            this.btnRiwayatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayatTransaksi.Location = new System.Drawing.Point(13, 212);
            this.btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            this.btnRiwayatTransaksi.Size = new System.Drawing.Size(213, 38);
            this.btnRiwayatTransaksi.TabIndex = 2;
            this.btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            this.btnRiwayatTransaksi.Click += new System.EventHandler(this.btnRiwayatTransaksi_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Location = new System.Drawing.Point(13, 272);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(213, 38);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // HistoryForm
            // 
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_history;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnRiwayatTransaksi);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.dgvHistory);
            this.Name = "HistoryForm";
            this.Text = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HistoryForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnProfil;
    }
}