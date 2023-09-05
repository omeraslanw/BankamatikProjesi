namespace BankamatikProjesi
{
    partial class FrmKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaydol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskHesap = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnKaydol);
            this.groupBox1.Controls.Add(this.mskTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskHesap);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(115, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 386);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(213, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "BankAslan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(156, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 35);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(156, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 35);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(156, 153);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(167, 35);
            this.mskTC.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(156, 336);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 35);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // mskHesap
            // 
            this.mskHesap.Enabled = false;
            this.mskHesap.Location = new System.Drawing.Point(156, 275);
            this.mskHesap.Mask = "000000";
            this.mskHesap.Name = "mskHesap";
            this.mskHesap.Size = new System.Drawing.Size(167, 35);
            this.mskHesap.TabIndex = 71;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(156, 214);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(167, 35);
            this.mskTelefon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telefon:";
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnKaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydol.Location = new System.Drawing.Point(345, 333);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(148, 41);
            this.btnKaydol.TabIndex = 7;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRandom.Location = new System.Drawing.Point(345, 278);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(50, 35);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "...";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FrmKaydol
            // 
            this.AcceptButton = this.btnKaydol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmKaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AslanBank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskHesap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnKaydol;
    }
}