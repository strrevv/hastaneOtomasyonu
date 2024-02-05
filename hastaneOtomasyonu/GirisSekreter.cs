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
    public partial class GirisSekreter : Form
    {
        public GirisSekreter()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();   
            Form fr = new Form1();
            fr.Show();    
        }

        private void GirisSekreter_Load(object sender, EventArgs e)
        {

        }

        private void btnDrGirisSek_Click(object sender, EventArgs e)
        {
            if (mtxtTcS.Text == "" || txtSifreS.Text == "")
            {
                MessageBox.Show("Boş alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Sekreterler where SekreterTC=@p1 and sekreterSifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", mtxtTcS.Text);
                komut.Parameters.AddWithValue("@p2", txtSifreS.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {

                    sekreterEkran frm = new sekreterEkran();
                    frm.skrtrtc = mtxtTcS.Text; 
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("TC Kimlik No veya Şifre hatalı lütfen tekrar deneyiniz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();

            }

        }
    }
}
