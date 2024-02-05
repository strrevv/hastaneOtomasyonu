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
    public partial class doktorGuncelle : Form
    {
        public doktorGuncelle()
        {
            InitializeComponent();
        }
        public string doktorId;
        //bilgileri çekme

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");
       
        private void doktorGuncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();    
            label5.Text = doktorId;
            SqlCommand komut = new SqlCommand("Select * from DoktorBilgi where doktorId=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", label5.Text);
            SqlDataReader dr =komut.ExecuteReader();    
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                TxtSifre.Text = dr[3].ToString();
                CmbBrans.Text = dr[4].ToString();
                MskTc.Text= dr[5].ToString();    
            }
            baglanti.Close();
            //combobox a verileri çekme
           
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select bransAd ,bransId from Branslar", baglanti);
            SqlDataReader dr2 =komut2.ExecuteReader();
            while(dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());  
                CmbBrans.DisplayMember = dr2[0].ToString(); 
                CmbBrans.ValueMember = dr2[1].ToString();   
            }
            baglanti.Close();
        }

        private void btnDrGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DialogResult secenek = MessageBox.Show("Sayın " + TxtAd.Text + " " + TxtSoyad.Text + " bilgilerinizi güncellensin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand komutguncelle = new SqlCommand("Update DoktorBilgi set bransId=@g1,doktorSifre=@g2 where doktorId=@g3", baglanti);
                komutguncelle.Parameters.AddWithValue("@g1", CmbBrans.ValueMember.ToString());
                komutguncelle.Parameters.AddWithValue("@g2", TxtSifre.Text);
                komutguncelle.Parameters.AddWithValue("@g3", label5.Text);
                komutguncelle.ExecuteNonQuery();
                

                SqlCommand komutguncellebrans = new SqlCommand("Update Randevular set doktorBrans=@p1 where randevuDoktor=@p2", baglanti);
                komutguncellebrans.Parameters.AddWithValue("@p1", CmbBrans.Text);
                komutguncellebrans.Parameters.AddWithValue("@p2", TxtAd.Text + " " + TxtSoyad.Text);
                komutguncellebrans.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Bilgileriniz başarıyla güncellendi");
                this.Close();   
            }
        }
    }
}
