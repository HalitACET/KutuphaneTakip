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
    public partial class Kitap_Ekleme_Formu : Form
    {
        public Kitap_Ekleme_Formu()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        public void listele()
        {
            //Kitaplar tablosu datagridview nesnesinde listelendi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void temizle()
        {
            //temizleme metodu
            txtID.Text = "";
            txtBarkod.Text = "";
            txtKitapAd.Text = "";
            txtYazar.Text = "";
            txtYayınEvi.Text = "";
            cmbKitaptur.Text = "";
            txtKitapSayfa.Text = "";
            rchtxtKitapKonu.Text = "";
            cmbBaskıYer.Text = "";
            textBox1.Text = "";
            txtKitapFiyat.Text = "";
            txtStok.Text = "";
        }
        private void Kitap_Ekleme_Formu_Load(object sender, EventArgs e)
        {
            //Kitap Türleri ve sehirler comboboxlara aktarıldı
            listele();
            SqlCommand komut = new SqlCommand("SELECT KitapTuru FROM Tbl_Kitap_Turleri",bgl.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKitaptur.Items.Add(dr[0]);
            }
            bgl.baglan().Close();

            SqlCommand komut2 = new SqlCommand("SELECT Sehirler FROM Tbl_Sehirler",bgl.baglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBaskıYer.Items.Add(dr2[0]);
            }
            bgl.baglan().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Kitap kaydetme sorgusu
            int a = Convert.ToInt16((+1) + cmbKitaptur.SelectedIndex);
            int b = Convert.ToInt16((+1) + cmbBaskıYer.SelectedIndex);
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kitaplar (BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,KitapTuruID,KitapSayfa,KitapKonu,BaskiYeriID,BaskiTarihi,KitapFiyati,Stok) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2",txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p3",txtYazar.Text);
            komut.Parameters.AddWithValue("@p4",txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@p5",a);
            komut.Parameters.AddWithValue("@p6", Convert.ToInt16(txtKitapSayfa.Text));
            komut.Parameters.AddWithValue("@p7",rchtxtKitapKonu.Text);
            komut.Parameters.AddWithValue("@p8",b);
            komut.Parameters.AddWithValue("@p9",Convert.ToDateTime(textBox1.Text).Date);
            komut.Parameters.AddWithValue("@p10",txtKitapFiyat.Text);
            komut.Parameters.AddWithValue("@p11", Convert.ToInt16(txtStok.Text));
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Kitap silme sorgusu
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Kitaplar WHERE Tbl_Kitaplar.ID=@p1",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBarkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKitapAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYayınEvi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbKitaptur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKitapSayfa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            rchtxtKitapKonu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbBaskıYer.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtKitapFiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //Kitap Güncelleme sorgusu
            int a = Convert.ToInt16((+1) + cmbKitaptur.SelectedIndex);
            int b = Convert.ToInt16((+1) + cmbBaskıYer.SelectedIndex);
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Kitaplar SET BarkodNo=@p1,KitapAd=@p2,YazarAdSoyad=@p3,YayinEvi=@p4,KitapTuruID=@p5,KitapSayfa=@p6,KitapKonu=@p7,BaskiYeriID=@p8,BaskiTarihi=@p9,KitapFiyati=@p10,Stok=@p11 WHERE ID=@p12",bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p3", txtYazar.Text);
            komut.Parameters.AddWithValue("@p4", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@p5", a);
            komut.Parameters.AddWithValue("@p6", Convert.ToInt16(txtKitapSayfa.Text));
            komut.Parameters.AddWithValue("@p7", rchtxtKitapKonu.Text);
            komut.Parameters.AddWithValue("@p8", b);
            komut.Parameters.AddWithValue("@p9", Convert.ToDateTime(textBox1.Text).Date);
            komut.Parameters.AddWithValue("@p10", txtKitapFiyat.Text);
            komut.Parameters.AddWithValue("@p11", Convert.ToInt16(txtStok.Text));
            komut.Parameters.AddWithValue("@p12", Convert.ToInt16(txtID.Text));
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
