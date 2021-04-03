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
    public partial class Tarihi_Geçenler : Form
    {
        public Tarihi_Geçenler()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void Tarihi_Geçenler_Load(object sender, EventArgs e)
        {
            //tarihi geçme sorgusu

            string date = DateTime.Now.ToShortDateString();
            label1.Text = date;
            
            SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Islemler.AlinanTarih < '"+date+"'",bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();

        }
    }
}
