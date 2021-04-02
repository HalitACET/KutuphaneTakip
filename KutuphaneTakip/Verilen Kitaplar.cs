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
    public partial class Verilen_Kitaplar : Form
    {
        public Verilen_Kitaplar()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void Verilen_Kitaplar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID inner join Tbl_Islemler on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
