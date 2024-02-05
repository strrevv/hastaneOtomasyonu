using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastaneOtomasyonu
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");   
       
        private void temizle()
        {
            txtBxHastaAd.Text = "";
            txtbxHastaSoyad.Text = "";
            mtxtDogumT.Text = "";
            mtxtTC.Text = "";
            cbxSehir.Text = "";
            mtxtTel.Text = "";
            txtPosta.Text = "";
            txtBAdi.Text = "";
            txtAAdi.Text = "";
            txtSifre.Text = "";
            richtxtAdres.Text = "";
            rbtnBekar.Checked = false;
            rbtnErkek.Checked = false;  
            rbtnEvli.Checked = false;   
            rbtnKız.Checked = false; 
            rBtnYok.Checked = false;
            rBtnVar.Checked = false;
            pictureBox1.ImageLocation = "";
        }
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet1.SaglıkGuvencesi' table. You can move, or remove it, as needed.
            this.saglıkGuvencesiTableAdapter.Fill(this.hastaneDataSet1.SaglıkGuvencesi);
            // TODO: This line of code loads data into the 'hastaneDataSet.iller2' table. You can move, or remove it, as needed.
            this.iller2TableAdapter.Fill(this.hastaneDataSet.iller2);
            cbxSigorta.Visible = false; 
            lblUcretli.Visible = false; 
            
        }

        private void rBtnVar_CheckedChanged_1(object sender, EventArgs e)
        {
            if(rBtnVar.Checked) 
            { 
                cbxSigorta.Visible = true;  
            
            }
           
        }

        private void rBtnYok_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnYok.Checked)
            {
                cbxSigorta.Visible = false;
                lblUcretli.Visible = true;
            }
            else if (!rBtnYok.Checked) 
            {
                lblUcretli.Visible=false;   
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            if (rbtnHasta.Checked)
            {
                this.Close();
                Form frm = new HastaGiris();
                frm.Show();
            }
            else if (rbtnSekreter.Checked)
            {
                this.Close();
                Form frm = new sekreterEkran(); 
                frm.Show();   
            }
             
             
        }
        string yol;
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            yol= openFileDialog1.FileName;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HastaBilgi (hastaAd ,hastaSoyad,hastaTC,hastaDogumTarihi,hastaDogumYeri,hastaCinsiyet" +
                ",hastaTelefon,hastaPosta,hastaMHal,hastaAnneAdı,hastaBabaAdı,hastaSigorta,hastaAdres,hastaResim,hastaSifre)" +
                " values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)",baglanti);

            komut.Parameters.AddWithValue("@p1", txtBxHastaAd.Text);
            komut.Parameters.AddWithValue("@p2", txtbxHastaSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtTC.Text);
            komut.Parameters.AddWithValue("@p4", mtxtDogumT.Text);
            komut.Parameters.AddWithValue("@p5", cbxSehir.Text);
            if(rbtnErkek.Checked)
            {
                komut.Parameters.AddWithValue("@p6", rbtnErkek.Text.ToString());
            }
            else if(rbtnKız.Checked)
            {
                komut.Parameters.AddWithValue("@p6", rbtnKız.Text.ToString());
            }
            
            komut.Parameters.AddWithValue("@p7", mtxtTel.Text.ToString());
            komut.Parameters.AddWithValue("@p8", txtPosta.Text);
            if(rbtnEvli.Checked) 
            {
                komut.Parameters.AddWithValue("@p9", rbtnEvli.Text);
            }
            else if (rbtnBekar.Checked)
            {
                komut.Parameters.AddWithValue("@p9",rbtnBekar.Text);

            }
            komut.Parameters.AddWithValue("@p10", txtAAdi.Text);
            komut.Parameters.AddWithValue("@p11", txtBAdi.Text);
            if(rBtnVar.Checked) 
            {
                komut.Parameters.AddWithValue("@p12", cbxSigorta.Text);
            }
            else if(rBtnYok.Checked) 
            {
                komut.Parameters.AddWithValue("@p12", lblUcretli.Text);
            }

            komut.Parameters.AddWithValue("@p13", richtxtAdres.Text);
            komut.Parameters.AddWithValue("@p14", yol);
            komut.Parameters.AddWithValue("@p15",txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi kaydı başarıyla gerçekleştirildi", "Kayıt Başarılı");
            temizle();
            

        }

        private void rbtnSekreter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chcBxKosul_CheckedChanged(object sender, EventArgs e)
        {
            if(chcBxKosul.Checked)
            {
                btnKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;  
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kullanimKosullari frm = new kullanimKosullari();    
            frm.ShowDialog();
        }
    }
}
