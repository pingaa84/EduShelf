namespace projekpbobismillah.form
{
    partial class ChapterForm
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
            this.txtChapterNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblJudulBuku = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lstChapter = new System.Windows.Forms.ListBox();
            this.txtChapterTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIsiChapter = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChapterNumber
            // 
            this.txtChapterNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtChapterNumber.BorderRadius = 2;
            this.txtChapterNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChapterNumber.DefaultText = "";
            this.txtChapterNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChapterNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChapterNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChapterNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChapterNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChapterNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChapterNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChapterNumber.Location = new System.Drawing.Point(277, 146);
            this.txtChapterNumber.Name = "txtChapterNumber";
            this.txtChapterNumber.PlaceholderText = "";
            this.txtChapterNumber.SelectedText = "";
            this.txtChapterNumber.Size = new System.Drawing.Size(242, 36);
            this.txtChapterNumber.TabIndex = 0;
            // 
            // lblJudulBuku
            // 
            this.lblJudulBuku.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulBuku.Location = new System.Drawing.Point(13, 12);
            this.lblJudulBuku.Name = "lblJudulBuku";
            this.lblJudulBuku.Size = new System.Drawing.Size(28, 15);
            this.lblJudulBuku.TabIndex = 1;
            this.lblJudulBuku.Text = "Judul";
            // 
            // lstChapter
            // 
            this.lstChapter.FormattingEnabled = true;
            this.lstChapter.Location = new System.Drawing.Point(27, 117);
            this.lstChapter.Name = "lstChapter";
            this.lstChapter.Size = new System.Drawing.Size(162, 355);
            this.lstChapter.TabIndex = 2;
            this.lstChapter.SelectedIndexChanged += new System.EventHandler(this.lstChapter_SelectedIndexChanged_1);
            // 
            // txtChapterTitle
            // 
            this.txtChapterTitle.BorderRadius = 2;
            this.txtChapterTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChapterTitle.DefaultText = "";
            this.txtChapterTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChapterTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChapterTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChapterTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChapterTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChapterTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChapterTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChapterTitle.Location = new System.Drawing.Point(277, 206);
            this.txtChapterTitle.Name = "txtChapterTitle";
            this.txtChapterTitle.PlaceholderText = "";
            this.txtChapterTitle.SelectedText = "";
            this.txtChapterTitle.Size = new System.Drawing.Size(242, 36);
            this.txtChapterTitle.TabIndex = 3;
            // 
            // txtIsiChapter
            // 
            this.txtIsiChapter.BackColor = System.Drawing.Color.White;
            this.txtIsiChapter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsiChapter.Location = new System.Drawing.Point(288, 283);
            this.txtIsiChapter.Name = "txtIsiChapter";
            this.txtIsiChapter.Size = new System.Drawing.Size(421, 139);
            this.txtIsiChapter.TabIndex = 4;
            this.txtIsiChapter.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(264, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(382, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(498, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 33);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(618, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 30);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ChapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.chapter;
            this.ClientSize = new System.Drawing.Size(807, 499);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIsiChapter);
            this.Controls.Add(this.txtChapterTitle);
            this.Controls.Add(this.lstChapter);
            this.Controls.Add(this.lblJudulBuku);
            this.Controls.Add(this.txtChapterNumber);
            this.Name = "ChapterForm";
            this.Text = "ChapterForm";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.ChapterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtChapterNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblJudulBuku;
        private System.Windows.Forms.ListBox lstChapter;
        private Guna.UI2.WinForms.Guna2TextBox txtChapterTitle;
        private System.Windows.Forms.RichTextBox txtIsiChapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}