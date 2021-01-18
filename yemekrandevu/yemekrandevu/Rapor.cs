using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemekrandevu
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhanerandevuDataSet1.Tbl_Kayitlar' table. You can move, or remove it, as needed.
            this.Tbl_KayitlarTableAdapter.Fill(this.yemekhanerandevuDataSet1.Tbl_Kayitlar);

            this.reportViewer1.RefreshReport();
        }
    }
}
