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
    public partial class duyurular : Form
    {
        public duyurular()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J61R85E;Initial Catalog=Hastane;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void duyurular_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select duyuru From Duyurular", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
    }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedColumns.ToString());
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
