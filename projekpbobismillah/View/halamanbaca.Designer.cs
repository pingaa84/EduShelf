namespace projekpbobismillah.form
{
    partial class HalamanBaca
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblJudulChapter = new System.Windows.Forms.Label();
            this.lstChapter = new System.Windows.Forms.ListBox();
            this.rtbTulisan = new System.Windows.Forms.RichTextBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnBacktoHome = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(213, 25);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(46, 18);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "label1";
            // 
            // lblJudulChapter
            // 
            this.lblJudulChapter.AutoSize = true;
            this.lblJudulChapter.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulChapter.Font = new System.Drawing.Font("PMingLiU-ExtB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulChapter.ForeColor = System.Drawing.Color.White;
            this.lblJudulChapter.Location = new System.Drawing.Point(291, 122);
            this.lblJudulChapter.Name = "lblJudulChapter";
            this.lblJudulChapter.Size = new System.Drawing.Size(93, 33);
            this.lblJudulChapter.TabIndex = 0;
            this.lblJudulChapter.Text = "label1";
            // 
            // lstChapter
            // 
            this.lstChapter.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChapter.FormattingEnabled = true;
            this.lstChapter.ItemHeight = 18;
            this.lstChapter.Location = new System.Drawing.Point(1, 64);
            this.lstChapter.Name = "lstChapter";
            this.lstChapter.Size = new System.Drawing.Size(191, 688);
            this.lstChapter.TabIndex = 1;
            // 
            // rtbTulisan
            // 
            this.rtbTulisan.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTulisan.Location = new System.Drawing.Point(210, 222);
            this.rtbTulisan.Name = "rtbTulisan";
            this.rtbTulisan.ReadOnly = true;
            this.rtbTulisan.Size = new System.Drawing.Size(1126, 406);
            this.rtbTulisan.TabIndex = 2;
            this.rtbTulisan.Text = "";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 8;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.FocusedColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1175, 648);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 33);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Selanjutnya";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BorderRadius = 8;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPrev.FocusedColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(978, 648);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(147, 33);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "Kembali";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnBacktoHome
            // 
            this.btnBacktoHome.BackColor = System.Drawing.Color.White;
            this.btnBacktoHome.BorderRadius = 8;
            this.btnBacktoHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBacktoHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBacktoHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBacktoHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBacktoHome.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBacktoHome.FocusedColor = System.Drawing.Color.White;
            this.btnBacktoHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBacktoHome.ForeColor = System.Drawing.Color.White;
            this.btnBacktoHome.Location = new System.Drawing.Point(24, 619);
            this.btnBacktoHome.Name = "btnBacktoHome";
            this.btnBacktoHome.Size = new System.Drawing.Size(147, 33);
            this.btnBacktoHome.TabIndex = 7;
            this.btnBacktoHome.Text = "Kembali ke Beranda";
            this.btnBacktoHome.Click += new System.EventHandler(this.btnBacktoHome_Click);
            // 
            // halamanbaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.ISI_BUKU;
            this.ClientSize = new System.Drawing.Size(1360, 721);
            this.Controls.Add(this.btnBacktoHome);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rtbTulisan);
            this.Controls.Add(this.lstChapter);
            this.Controls.Add(this.lblJudulChapter);
            this.Controls.Add(this.lblJudul);
            this.Name = "halamanbaca";
            this.Text = "halamanbaca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.halamanbaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblJudulChapter;
        private System.Windows.Forms.ListBox lstChapter;
        private System.Windows.Forms.RichTextBox rtbTulisan;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnBacktoHome;
    }
}