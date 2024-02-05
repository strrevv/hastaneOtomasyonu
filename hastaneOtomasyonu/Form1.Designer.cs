namespace hastaneOtomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctrBxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pctrBxLogo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnHasta);
            this.panel3.Controls.Add(this.btnSekreter);
            this.panel3.Controls.Add(this.btnDoktor);
            this.panel3.Controls.Add(this.lblBaslik);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 550);
            this.panel3.TabIndex = 1;
            // 
            // pctrBxLogo
            // 
            this.pctrBxLogo.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.logo1;
            this.pctrBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrBxLogo.Location = new System.Drawing.Point(183, 56);
            this.pctrBxLogo.Name = "pctrBxLogo";
            this.pctrBxLogo.Size = new System.Drawing.Size(158, 156);
            this.pctrBxLogo.TabIndex = 14;
            this.pctrBxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(395, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sekreter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doktor";
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.hassta;
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHasta.Location = new System.Drawing.Point(360, 312);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(131, 191);
            this.btnHasta.TabIndex = 10;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.sekreter;
            this.btnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekreter.Location = new System.Drawing.Point(199, 313);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(131, 191);
            this.btnSekreter.TabIndex = 9;
            this.btnSekreter.UseVisualStyleBackColor = true;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackgroundImage = global::hastaneOtomasyonu.Properties.Resources.doktor;
            this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoktor.Location = new System.Drawing.Point(37, 312);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(131, 191);
            this.btnDoktor.TabIndex = 8;
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(149, 19);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(208, 22);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "HASTANE SİSTEM GİRİŞİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 550);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBYS";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnHasta;
        public System.Windows.Forms.Button btnSekreter;
        public System.Windows.Forms.Button btnDoktor;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctrBxLogo;
    }
}

