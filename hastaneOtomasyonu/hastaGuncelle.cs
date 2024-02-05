using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneOtomasyonu
{
    public partial class hastaGuncelle : Form
    {
        public hastaGuncelle()
        {
            InitializeComponent();
        }
        public string tcno;

        SqlConnection baglanti3 = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        private void hastaGuncelle_Load(object sender, EventArgs e)
        {
            label6.Text = tcno;
            baglanti3.Open();
            SqlCommand komut = new SqlCommand("Select hastaAd,hastaSoyad,hastaTelefon,hastaPosta,hastaSifre from HastaBilgi where hastaTc=@p1",baglanti3);
            komut.Parameters.AddWithValue("@p1", label6.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read()) 
            {
                txtAd.Text = dataReader[0].ToString();
                txtSoyad.Text = dataReader[1].ToString();
                maskedTextBox1.Text = dataReader[2].ToString();
                txtMail.Text = dataReader[3].ToString();
                txtSifre.Text= dataReader[4].ToString();
               
            }
            baglanti3.Close();  

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti3.Open();
            DialogResult secenek = MessageBox.Show("Merhaba" + " " + txtAd.Text + " " + "bilgileriniz güncellensin mi ?", "Hasta Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update HastaBilgi set hastaAd=@p1,hastaSoyad=@p2,hastaTelefon=@p3,hastaPosta=@p4,hastaSifre=@p5 where hastaTc=@p6", baglanti3);
                komut.Parameters.AddWithValue("@p1",txtAd.Text);
                komut.Parameters.AddWithValue("@p2",  txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p4", txtMail.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.Parameters.AddWithValue("@p6", label6.Text);
                komut.ExecuteNonQuery();
                baglanti3.Close();
                MessageBox.Show("Bilgileriniz güncellendi", "Başarılı güncelleme");
                this.Hide();

            }
        }
    }
}
