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
    public partial class sekreterEkran : Form
    {
        public sekreterEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        public string skrtrtc;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            
             dr =MessageBox.Show("Çıkış yapmak istediğinize emin misiniz","Çıkış",MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new HastaKayit();
            form.ShowDialog();  
        }

        private void sekreterEkran_Load(object sender, EventArgs e)
        {
            

            dtPickerTarih.MinDate = DateTime.Today;
              dtPickerTarih.MaxDate = DateTime.Now.AddDays(7);


            label6.Text = skrtrtc;

            baglanti.Open();
            

            SqlCommand komut = new SqlCommand("Select sekreterAdSoyad , SekreterTC From Sekreterler where SekreterTC=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",label6.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            if (dr.Read())
            {
                label8.Text = dr[0].ToString();
                label9.Text= dr[1].ToString();   
            }

            baglanti.Close();

            baglanti.Open();
            
            // branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select bransAd From Branslar", baglanti);
            da1.Fill(dt1);
           dtGrdBrans.DataSource = dt1;
            // doktorları datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorAd + ' ' + doktorSoyad) as 'Doktorlar' From DoktorBilgi", baglanti);
            da2.Fill(dt2);
            dtGrdDoktor.DataSource = dt2;

            SqlCommand komut2 = new SqlCommand("Select bransAd From Branslar", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0].ToString());
            }

            baglanti.Close();

            baglanti.Open();    
            DataTable dt3 = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from Randevular", baglanti);
            dap.Fill(dt3);  
            dtGrdRandevu.DataSource = dt3;  

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            duyurular duyuru = new duyurular();
            duyuru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAd , doktorSoyad from DoktorBilgi where bransId=@b1", baglanti);
            komut3.Parameters.AddWithValue("@b1", comboBox1.SelectedIndex);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0].ToString() + " " + dr3[1].ToString());
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("insert into Duyurular (duyuru)"+"values(@p1)",baglanti);
            komut4.Parameters.AddWithValue("@p1", rTxtDuyuru.Text);
            komut4.ExecuteNonQuery();   
            baglanti.Close() ;

            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnSiraVer_Click(object sender, EventArgs e)
        {
            baglanti.Open() ;


            SqlCommand randevukomut = new SqlCommand("insert into Randevular (randevuSaat,randevuTarih,doktorBrans,randevuDoktor,randevuDurum,randevuHastaTc)" +
                   "values(@r1,@r2,@r3,@r4,@r5,@r6)", baglanti);
            randevukomut.Parameters.AddWithValue("@r1", mtxtSaatRandevu.Text);
            randevukomut.Parameters.AddWithValue("@r2", dtPickerTarih.Text);
            randevukomut.Parameters.AddWithValue("@r3", comboBox1.Text);
            randevukomut.Parameters.AddWithValue("@r4", comboBox2.Text);
            randevukomut.Parameters.AddWithValue("@r5", true);
            randevukomut.Parameters.AddWithValue("@r6", mtxtTC.Text);
            randevukomut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("randevu oluşturuldu");


            mtxtSaatRandevu.Text = "";
            dtPickerTarih.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
         
        }

       

        private void verileriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart chr = new Chart();
            chr.Show();
         
        }
    }
}
