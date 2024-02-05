using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneOtomasyonu
{
    public partial class kullanimKosullari : Form
    {
        public kullanimKosullari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaKayit frm = new HastaKayit();
            this.Close();
        }

        private void kullanimKosullari_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\eelif\\Downloads\\eczacibasi-holding-websitesi-kullanim-kosullari.pdf");
        }
    }
}
