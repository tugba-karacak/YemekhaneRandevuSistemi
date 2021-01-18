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

namespace yemekrandevu
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TK\\SQLEXPRESS;Initial Catalog=yemekhanerandevu;Integrated Security=True");
        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select  ad, soyad, birim, tarih from Tbl_Kayitlar ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
