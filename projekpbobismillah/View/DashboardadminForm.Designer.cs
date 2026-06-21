namespace projekpbobismillah.form
{
    partial class DashboardAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalBuku = new System.Windows.Forms.Label();
            this.chartMemberPremium = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMember = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnManajemenBuku = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnManajemenMember = new System.Windows.Forms.Button();
            this.btnKelolaAkun = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemberPremium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTotalBuku);
            this.panel1.Location = new System.Drawing.Point(320, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalBuku
            // 
            this.lblTotalBuku.AutoSize = true;
            this.lblTotalBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBuku.Location = new System.Drawing.Point(848, 10);
            this.lblTotalBuku.Name = "lblTotalBuku";
            this.lblTotalBuku.Size = new System.Drawing.Size(39, 42);
            this.lblTotalBuku.TabIndex = 1;
            this.lblTotalBuku.Text = "0\r\n";
            // 
            // chartMemberPremium
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMemberPremium.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMemberPremium.Legends.Add(legend1);
            this.chartMemberPremium.Location = new System.Drawing.Point(332, 413);
            this.chartMemberPremium.Name = "chartMemberPremium";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMemberPremium.Series.Add(series1);
            this.chartMemberPremium.Size = new System.Drawing.Size(273, 234);
            this.chartMemberPremium.TabIndex = 1;
            this.chartMemberPremium.Text = "chart1";
            this.chartMemberPremium.Click += new System.EventHandler(this.chartMemberPremium_Click);
            // 
            // chartMember
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMember.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMember.Legends.Add(legend2);
            this.chartMember.Location = new System.Drawing.Point(681, 413);
            this.chartMember.Name = "chartMember";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMember.Series.Add(series2);
            this.chartMember.Size = new System.Drawing.Size(273, 234);
            this.chartMember.TabIndex = 2;
            this.chartMember.Text = "chart2";
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend3);
            this.chartRevenue.Location = new System.Drawing.Point(999, 413);
            this.chartRevenue.Name = "chartRevenue";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRevenue.Series.Add(series3);
            this.chartRevenue.Size = new System.Drawing.Size(287, 234);
            this.chartRevenue.TabIndex = 3;
            this.chartRevenue.Text = "chart3";
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // btnManajemenBuku
            // 
            this.btnManajemenBuku.BackColor = System.Drawing.Color.Transparent;
            this.btnManajemenBuku.FlatAppearance.BorderSize = 0;
            this.btnManajemenBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenBuku.Location = new System.Drawing.Point(12, 161);
            this.btnManajemenBuku.Name = "btnManajemenBuku";
            this.btnManajemenBuku.Size = new System.Drawing.Size(226, 44);
            this.btnManajemenBuku.TabIndex = 4;
            this.btnManajemenBuku.UseVisualStyleBackColor = false;
            this.btnManajemenBuku.Click += new System.EventHandler(this.btnManajemenBuku_Click);
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.Transparent;
            this.btnSubscription.FlatAppearance.BorderSize = 0;
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Location = new System.Drawing.Point(12, 217);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(226, 43);
            this.btnSubscription.TabIndex = 5;
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // btnManajemenMember
            // 
            this.btnManajemenMember.BackColor = System.Drawing.Color.Transparent;
            this.btnManajemenMember.FlatAppearance.BorderSize = 0;
            this.btnManajemenMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenMember.Location = new System.Drawing.Point(12, 271);
            this.btnManajemenMember.Name = "btnManajemenMember";
            this.btnManajemenMember.Size = new System.Drawing.Size(226, 43);
            this.btnManajemenMember.TabIndex = 6;
            this.btnManajemenMember.UseVisualStyleBackColor = false;
            this.btnManajemenMember.Click += new System.EventHandler(this.btnManajemenMember_Click);
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
            this.btnKelolaAkun.Location = new System.Drawing.Point(12, 628);
            this.btnKelolaAkun.Name = "btnKelolaAkun";
            this.btnKelolaAkun.Size = new System.Drawing.Size(226, 60);
            this.btnKelolaAkun.TabIndex = 7;
            this.btnKelolaAkun.Click += new System.EventHandler(this.btnKelolaAkun_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1200, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_admindashboard;
            this.ClientSize = new System.Drawing.Size(1350, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKelolaAkun);
            this.Controls.Add(this.btnManajemenMember);
            this.Controls.Add(this.btnSubscription);
            this.Controls.Add(this.btnManajemenBuku);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chartMember);
            this.Controls.Add(this.chartMemberPremium);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardadminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardAdmin_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemberPremium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalBuku;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMemberPremium;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMember;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button btnManajemenBuku;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Button btnManajemenMember;
        private Guna.UI2.WinForms.Guna2Button btnKelolaAkun;
        private System.Windows.Forms.Button button1;
    }
}