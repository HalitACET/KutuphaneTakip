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
namespace KutuphaneTakip
{
    public partial class KitapListesi : Form
    {
        public KitapListesi()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void KitapListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kitaplar",bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
