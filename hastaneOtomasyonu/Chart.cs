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
using System.Windows.Forms.DataVisualization.Charting;
namespace hastaneOtomasyonu
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");
        private void Chart_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select doktorAd,hastaSayi From DoktorBilgi", baglanti);
            SqlDataReader oku= komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["sigorta"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            baglanti.Close();
        }
    }
}
