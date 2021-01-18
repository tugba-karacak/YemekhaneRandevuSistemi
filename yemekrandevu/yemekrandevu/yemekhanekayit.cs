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
    public partial class yemekhanekayit : Form
    {
        public yemekhanekayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TK\\SQLEXPRESS;Initial Catalog=yemekhanerandevu;Integrated Security=True");

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kayitlar (ad,soyad,birim,tarih) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbirim.Text);
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
      
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yemek Kaydı Oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            Liste();

        }

        private void yemekhanekayit_Load(object sender, EventArgs e)
        {
            Liste();
        }
        void Liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kayitlar ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbirim.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Liste();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Liste();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komuts = new SqlCommand("delete  from  Tbl_Kayitlar where id=@p1", baglanti);
            komuts.Parameters.AddWithValue("@p1", txtid.Text);
            komuts.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yemek Kaydı Silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Liste();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg = new SqlCommand("update Tbl_Kayitlar set ad=@p1,soyad=@p2, birim=@p3, tarih=@p4 where id=@p5", baglanti);
            komutg.Parameters.AddWithValue("@p1", txtad.Text);
            komutg.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutg.Parameters.AddWithValue("@p3", cmbbirim.Text);
            komutg.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
            komutg.Parameters.AddWithValue("@p5", txtid.Text);
            komutg.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yemek Kaydı Güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Liste();
        }

        private void btnkayitlarigoruntule_Click(object sender, EventArgs e)
        {
            KayitEkrani fr = new KayitEkrani();
            fr.Show();
        }

        private void btnraporla_Click(object sender, EventArgs e)
        {
            Rapor fr = new Rapor();
            fr.Show();
        }
    }
}
