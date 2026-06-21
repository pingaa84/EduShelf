namespace projekpbobismillah.form
{
    partial class AddEditBook
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
            this.btnUploadCover = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.cmbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnManageChapter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadCover
            // 
            this.btnUploadCover.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadCover.FlatAppearance.BorderSize = 0;
            this.btnUploadCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadCover.Location = new System.Drawing.Point(273, 286);
            this.btnUploadCover.Name = "btnUploadCover";
            this.btnUploadCover.Size = new System.Drawing.Size(117, 36);
            this.btnUploadCover.TabIndex = 2;
            this.btnUploadCover.UseVisualStyleBackColor = false;
            this.btnUploadCover.Click += new System.EventHandler(this.btnUploadCover_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(555, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 3;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(273, 159);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(456, 44);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderRadius = 3;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(273, 236);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(456, 44);
            this.txtAuthor.TabIndex = 5;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(273, 383);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 7;
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.DimGray;
            this.cmbKategori.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbKategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbKategori.ItemHeight = 30;
            this.cmbKategori.Location = new System.Drawing.Point(273, 328);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(214, 36);
            this.cmbKategori.TabIndex = 8;
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.Transparent;
            this.picCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCover.Location = new System.Drawing.Point(30, 170);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(161, 204);
            this.picCover.TabIndex = 6;
            this.picCover.TabStop = false;
            // 
            // btnManageChapter
            // 
            this.btnManageChapter.BackColor = System.Drawing.Color.Transparent;
            this.btnManageChapter.FlatAppearance.BorderSize = 0;
            this.btnManageChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageChapter.Location = new System.Drawing.Point(677, 453);
            this.btnManageChapter.Name = "btnManageChapter";
            this.btnManageChapter.Size = new System.Drawing.Size(108, 23);
            this.btnManageChapter.TabIndex = 9;
            this.btnManageChapter.UseVisualStyleBackColor = false;
            this.btnManageChapter.Click += new System.EventHandler(this.btnManageChapter_Click);
            // 
            // AddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.addbook;
            this.ClientSize = new System.Drawing.Size(812, 488);
            this.Controls.Add(this.btnManageChapter);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUploadCover);
            this.Name = "AddEditBook";
            this.Text = "AddEditBook";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.AddEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUploadCover;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.DateTimePicker datetime;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategori;
        private System.Windows.Forms.Button btnManageChapter;
    }
}