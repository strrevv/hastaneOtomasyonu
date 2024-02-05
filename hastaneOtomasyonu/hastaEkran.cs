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
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Markup;

namespace hastaneOtomasyonu
{
    public partial class hastaEkran : Form
    {
        public hastaEkran()
        {
            InitializeComponent();
        }
        
        public string Hastatc;
      
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        void randevuGecmisiListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevular where randevuHastaTc='" + label1.Text+"' "+" and randevuDurum=1 ",baglanti);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
       
        void randevugecmis()
        {
            bool durum = false;
            DataTable dta = new DataTable();
            SqlDataAdapter dab = new SqlDataAdapter("Select * from Randevular where randevuHastaTc='" + Hastatc +"' "+" and randevuDurum=0" , baglanti);
            dab.Fill(dta);
            dataGridView1.DataSource = dta; 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastaGuncelle frm = new hastaGuncelle();
            frm.tcno = Hastatc; ;
            frm.ShowDialog();
            this.Hide();
        }

      

        private void hastaEkran_Load(object sender, EventArgs e)
        {
            dtPickerRandevu.MinDate = DateTime.Today;
            dtPickerRandevu.MaxDate = DateTime.Now.AddDays(7);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            label1.Text = Hastatc;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select hastaAd,hastaSoyad,hastaResim From HastaBilgi where hastaTC=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1",label1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblAdGiris.Text = dr[0].ToString();
                lblSoyadGiris.Text= dr[1].ToString();   
                pictureBox1.ImageLocation= dr[2].ToString();
            }
            baglanti.Close();

            randevuGecmisiListele();
            randevugecmis();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select bransAd From Branslar ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader(); 
            while(dr2.Read())
            {
                cbxBrans.Items.Add(dr2[0].ToString());  
            }

            baglanti.Close();


        }
        //combobox a doktorları getirme
        private void cbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            cbxDoktor.Text = "";
            cbxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAd , doktorSoyad from DoktorBilgi where bransId=@b1", baglanti);
            komut3.Parameters.AddWithValue("@b1", cbxBrans.SelectedIndex);
            SqlDataReader dr3 = komut3.ExecuteReader(); 
            while(dr3.Read())
            {
                cbxDoktor.Items.Add(dr3[0].ToString()+" "+ dr3[1].ToString());
            }
            baglanti.Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where randevuDurum=0" ,baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if(cbxDoktor.Text==" " || cbxBrans.Text==" " || rtxtSikayet.Text==" ")
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand randevukomut = new SqlCommand("insert into Randevular (randevuSaat,randevuTarih,doktorBrans,randevuDoktor,randevuDurum,randevuHastaTc,randevuHastaSikayet)"+
                    "values(@r1,@r2,@r3,@r4,@r5,@r6,@r7)",baglanti);
                randevukomut.Parameters.AddWithValue("@r1",mtxtRandevuSaat.Text);
                randevukomut.Parameters.AddWithValue("@r2",dtPickerRandevu.Text);
                randevukomut.Parameters.AddWithValue("@r3", cbxBrans.Text);
                randevukomut.Parameters.AddWithValue("@r4", cbxDoktor.Text);
                randevukomut.Parameters.AddWithValue("@r5", true);
                randevukomut.Parameters.AddWithValue("@r6", Hastatc);
                randevukomut.Parameters.AddWithValue("@r7", rtxtSikayet.Text);
                randevukomut.ExecuteNonQuery(); 
                baglanti.Close();
                MessageBox.Show("Sayın"+ lblAdGiris.Text +"  "+cbxBrans.Text+"Bölümüne"+cbxDoktor.Text+"İsimli doktora"+
                   dtPickerRandevu.Text +"tarihinde "+mtxtRandevuSaat.Text+"saatinde randevunuz başarıyla oluşturulmuştur","Randevu Oluşturuldu" );
                mtxtRandevuSaat.Text = "";
                dtPickerRandevu.Text = "";
                cbxBrans.Text = "";
                cbxDoktor.Text = "";
                rtxtSikayet.Text = "";
                randevuGecmisiListele();
                
            }
        }

        

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            lblId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void gbxBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void btnHastaCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("çıkış yapmak istediğinize emin misiniz","çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HastaGiris frm =new HastaGiris();
                frm.Show();
               this.Close();
            }


        }
    }
}
