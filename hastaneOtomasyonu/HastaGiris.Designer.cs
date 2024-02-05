namespace hastaneOtomasyonu
{
    partial class HastaGiris
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtSifreH = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnDrGirisSek = new System.Windows.Forms.Button();
            this.mtxtGTC = new System.Windows.Forms.MaskedTextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.images;
            this.btnGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoster.Location = new System.Drawing.Point(344, 124);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(30, 20);
            this.btnGoster.TabIndex = 20;
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(27, 365);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(14, 52);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(198, 23);
            this.lblKullaniciAdi.TabIndex = 17;
            this.lblKullaniciAdi.Text = " TC Kimlik Numarası :";
            // 
            // txtSifreH
            // 
            this.txtSifreH.Location = new System.Drawing.Point(238, 125);
            this.txtSifreH.Name = "txtSifreH";
            this.txtSifreH.PasswordChar = '*';
            this.txtSifreH.Size = new System.Drawing.Size(100, 20);
            this.txtSifreH.TabIndex = 22;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Location = new System.Drawing.Point(151, 124);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 23);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre :";
            // 
            // btnDrGirisSek
            // 
            this.btnDrGirisSek.Location = new System.Drawing.Point(85, 230);
            this.btnDrGirisSek.Name = "btnDrGirisSek";
            this.btnDrGirisSek.Size = new System.Drawing.Size(268, 31);
            this.btnDrGirisSek.TabIndex = 23;
            this.btnDrGirisSek.Text = "Giriş";
            this.btnDrGirisSek.UseVisualStyleBackColor = true;
            this.btnDrGirisSek.Click += new System.EventHandler(this.btnDrGirisSek_Click);
            // 
            // mtxtGTC
            // 
            this.mtxtGTC.Location = new System.Drawing.Point(238, 52);
            this.mtxtGTC.Mask = "00000000000";
            this.mtxtGTC.Name = "mtxtGTC";
            this.mtxtGTC.Size = new System.Drawing.Size(100, 20);
            this.mtxtGTC.TabIndex = 21;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(85, 286);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(268, 31);
            this.btnKayit.TabIndex = 22;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click_1);
            // 
            // HastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.mtxtGTC);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifreH);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnDrGirisSek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giris";
            this.Load += new System.EventHandler(this.HastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifreH;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnDrGirisSek;
        private System.Windows.Forms.Button btnKayit;
        public System.Windows.Forms.MaskedTextBox mtxtGTC;
    }
}