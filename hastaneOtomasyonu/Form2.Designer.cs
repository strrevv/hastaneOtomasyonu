namespace hastaneOtomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnDrGiris = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtDoktorId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrGiris
            // 
            this.btnDrGiris.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDrGiris.Location = new System.Drawing.Point(102, 186);
            this.btnDrGiris.Name = "btnDrGiris";
            this.btnDrGiris.Size = new System.Drawing.Size(260, 41);
            this.btnDrGiris.TabIndex = 0;
            this.btnDrGiris.Text = "Giriş";
            this.btnDrGiris.UseVisualStyleBackColor = false;
            this.btnDrGiris.Click += new System.EventHandler(this.btnDrGiris_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(90, 121);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(68, 26);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSifre.Location = new System.Drawing.Point(175, 122);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 30);
            this.txtSifre.TabIndex = 2;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(90, 55);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(48, 26);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "ID :";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 295);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(90, 28);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtDoktorId);
            this.panel1.Controls.Add(this.btnDrGiris);
            this.panel1.Controls.Add(this.btnGoster);
            this.panel1.Controls.Add(this.lblKullaniciAdi);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Location = new System.Drawing.Point(1, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 260);
            this.panel1.TabIndex = 7;
            // 
            // btnGoster
            // 
            this.btnGoster.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.images;
            this.btnGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoster.Location = new System.Drawing.Point(296, 122);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(38, 30);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtDoktorId
            // 
            this.txtDoktorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDoktorId.Location = new System.Drawing.Point(175, 61);
            this.txtDoktorId.Name = "txtDoktorId";
            this.txtDoktorId.Size = new System.Drawing.Size(100, 30);
            this.txtDoktorId.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrGiris;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDoktorId;
    }
}