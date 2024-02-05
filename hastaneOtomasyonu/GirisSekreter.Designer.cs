namespace hastaneOtomasyonu
{
    partial class GirisSekreter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSekreter));
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtSifreS = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnDrGirisSek = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.mtxtTcS = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(9, 293);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(30, 32);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(147, 26);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı ";
            // 
            // txtSifreS
            // 
            this.txtSifreS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSifreS.Location = new System.Drawing.Point(47, 165);
            this.txtSifreS.Name = "txtSifreS";
            this.txtSifreS.PasswordChar = '*';
            this.txtSifreS.Size = new System.Drawing.Size(100, 30);
            this.txtSifreS.TabIndex = 9;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Location = new System.Drawing.Point(31, 122);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(56, 26);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre";
            // 
            // btnDrGirisSek
            // 
            this.btnDrGirisSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDrGirisSek.Location = new System.Drawing.Point(65, 217);
            this.btnDrGirisSek.Name = "btnDrGirisSek";
            this.btnDrGirisSek.Size = new System.Drawing.Size(82, 27);
            this.btnDrGirisSek.TabIndex = 7;
            this.btnDrGirisSek.Text = "Giriş";
            this.btnDrGirisSek.UseVisualStyleBackColor = true;
            this.btnDrGirisSek.Click += new System.EventHandler(this.btnDrGirisSek_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.images;
            this.btnGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGoster.Location = new System.Drawing.Point(153, 173);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(30, 20);
            this.btnGoster.TabIndex = 13;
            this.btnGoster.UseVisualStyleBackColor = true;
            // 
            // mtxtTcS
            // 
            this.mtxtTcS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtxtTcS.Location = new System.Drawing.Point(47, 71);
            this.mtxtTcS.Mask = "00000000000";
            this.mtxtTcS.Name = "mtxtTcS";
            this.mtxtTcS.Size = new System.Drawing.Size(100, 30);
            this.mtxtTcS.TabIndex = 14;
            // 
            // GirisSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(224, 330);
            this.Controls.Add(this.mtxtTcS);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifreS);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnDrGirisSek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisSekreter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Sekreter";
            this.Load += new System.EventHandler(this.GirisSekreter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifreS;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnDrGirisSek;
        private System.Windows.Forms.MaskedTextBox mtxtTcS;
    }
}