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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID ", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();

            SqlCommand komut = new SqlCommand("Select YazarAdSoyad From Tbl_Kitaplar",bgl.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbYazar.Items.Add(dr[0]);
            }
            bgl.baglan().Close();

            SqlCommand komut2 = new SqlCommand("Select YayinEvi From Tbl_Kitaplar", bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbYayinEvi.Items.Add(dr2[0]);
            }
            bgl.baglan().Close();

            SqlCommand komut3 = new SqlCommand("Select KitapTuru From Tbl_Kitap_Turleri ", bgl.baglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbKitapturu.Items.Add(dr3[0]);
            }
            bgl.baglan().Close();
        }

        private void txtKitapAd_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where KitapAd like '%" + txtKitapAd.Text + "%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where BarkodNo like '%" + txtBarkodNo.Text + "%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbYazar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where YazarAdSoyad like '%" + cmbYazar.Text + "%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbYayinEvi_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where YayinEvi like '%" + cmbYayinEvi.Text + "%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbKitapturu_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where Tbl_Kitap_Turleri.KitapTuru like '%" + cmbKitapturu.Text + "%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where KitapSayfa between @p1 and @p2", bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtSayfaSol.Text);
            komut.Parameters.AddWithValue("@p2",txtSayfaSag.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where KitapFiyati between @p1 and @p2", bgl.baglan());
            komut.Parameters.AddWithValue("@p1",Convert.ToInt16( txtFiyatSol.Text));
            komut.Parameters.AddWithValue("@p2",Convert.ToInt16( txtFiyatSag.Text));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID ", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }
    }
}
