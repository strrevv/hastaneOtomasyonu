using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void btnDoktor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2();
            frm.ShowDialog();   
           
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new GirisSekreter();
            form.ShowDialog();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new HastaGiris();
            frm.ShowDialog();   
            
        }

    

      
    }
}
