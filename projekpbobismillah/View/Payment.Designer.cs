namespace projekpbobismillah.form
{
    partial class Payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbDana = new System.Windows.Forms.RadioButton();
            this.rbOvo = new System.Windows.Forms.RadioButton();
            this.rbGopay = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbTransfer);
            this.groupBox1.Controls.Add(this.rbDana);
            this.groupBox1.Controls.Add(this.rbOvo);
            this.groupBox1.Controls.Add(this.rbGopay);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(751, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(409, 288);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(14, 13);
            this.rbTransfer.TabIndex = 3;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.UseVisualStyleBackColor = true;
            // 
            // rbDana
            // 
            this.rbDana.AutoSize = true;
            this.rbDana.Location = new System.Drawing.Point(409, 181);
            this.rbDana.Name = "rbDana";
            this.rbDana.Size = new System.Drawing.Size(14, 13);
            this.rbDana.TabIndex = 2;
            this.rbDana.TabStop = true;
            this.rbDana.UseVisualStyleBackColor = true;
            // 
            // rbOvo
            // 
            this.rbOvo.AutoSize = true;
            this.rbOvo.Location = new System.Drawing.Point(409, 109);
            this.rbOvo.Name = "rbOvo";
            this.rbOvo.Size = new System.Drawing.Size(14, 13);
            this.rbOvo.TabIndex = 1;
            this.rbOvo.TabStop = true;
            this.rbOvo.UseVisualStyleBackColor = true;
            // 
            // rbGopay
            // 
            this.rbGopay.AutoSize = true;
            this.rbGopay.Location = new System.Drawing.Point(409, 32);
            this.rbGopay.Name = "rbGopay";
            this.rbGopay.Size = new System.Drawing.Size(14, 13);
            this.rbGopay.TabIndex = 0;
            this.rbGopay.TabStop = true;
            this.rbGopay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(981, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 59);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projekpbobismillah.Properties.Resources.halaman_payment;
            this.ClientSize = new System.Drawing.Size(1347, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGopay;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbDana;
        private System.Windows.Forms.RadioButton rbOvo;
        private System.Windows.Forms.Button button1;
    }
}