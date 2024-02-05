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
    public partial class doktorEkran : Form
    {
        public doktorEkran()
        {
            InitializeComponent();
        }
        public string dId;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            Form form = new duyurular();
            form.ShowDialog();  
        }

        private void doktorEkran_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            labelGecis.Text = dId;
            SqlCommand komut = new SqlCommand("Select doktorAd,doktorSoyad,doktorTc From DoktorBilgi where doktorId=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", labelGecis.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblDrAd.Text = dr[0].ToString();
                lblDrSoyad.Text = dr[1].ToString();
                lblTc.Text = dr[2].ToString();  
            }
            baglanti.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where randevuDoktor='" + lblDrAd.Text+" "+lblDrSoyad.Text + "' and Randevudurum=1", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorGuncelle drguncelle = new doktorGuncelle();
            drguncelle.doktorId = dId;
            drguncelle.Show(); 
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
            {
                this.Close();

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           richTextBox1.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }


        private void btnGonder_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Randevular set randevuDurum=0 ,randevuTani=@p1 where RandevuHastaTc=@p2",baglanti);
            cmd.Parameters.AddWithValue("@p1", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            cmd.ExecuteNonQuery();  
            baglanti.Close();


            MessageBox.Show("Başarılı");

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();  
        }
    }
}
