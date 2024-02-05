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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hastaneOtomasyonu
{
    public partial class HastaGiris : Form
    {
        hastaEkran hastaEkran;
        public HastaGiris()
        {
            InitializeComponent();
        }
        public string GetTextBoxValue()
        {
            return mtxtGTC.Text;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

       
        private void HastaGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Form1();
            form.Show();
        }


        

        private void btnKayit_Click_1(object sender, EventArgs e)
        {
            Form frm = new HastaKayit();
            frm.Show();
            this.Hide();
            

        }

        private void btnDrGirisSek_Click(object sender, EventArgs e)
        {
            if(txtSifreH.Text=="" || mtxtGTC.Text=="")
            {
                MessageBox.Show("Boş alanları Doldurunuz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                baglanti.Open();
             SqlCommand komut = new SqlCommand("Select * From HastaBilgi where hastaTC=@p1 and hastaSifre=@p2",baglanti);
                komut.Parameters.AddWithValue("@p1",mtxtGTC.Text);
                komut.Parameters.AddWithValue("@p2",txtSifreH.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read()) 
                {

                    hastaEkran frm = new hastaEkran();
                    frm.Hastatc = mtxtGTC.Text;
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

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtSifreH.PasswordChar == '*')
            {
                txtSifreH.PasswordChar = '\0';
            }
            else
            {
                txtSifreH.PasswordChar = '*';
            }
        }
    }
}
