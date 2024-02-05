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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Form1();
            form.Show();
            

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar=='*') 
            {
                txtSifre.PasswordChar ='\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

     

       

        private void btnDrGiris_Click(object sender, EventArgs e)
        {

            if (txtDoktorId.Text == " " || txtSifre.Text == " ")
            {
                MessageBox.Show("Boş alanları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From DoktorBilgi where doktorId=@p1 and doktorSifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtDoktorId.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {

                  doktorEkran frm = new doktorEkran();  
                    frm.dId= txtDoktorId.Text;  
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("ID veya Şifre hatalı lütfen tekrar deneyiniz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();

            }

           
        }
    }
}
