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
    public partial class Kitap_Verme : Form
    {
        public Kitap_Verme()
        {
            InitializeComponent();
        }
        public int a;
        Baglanti bgl = new Baglanti();
        public void UyeListele()
        {
            //datagridview nesnesine üyeler listeleniyor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Uyeler",bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void KitapListele()
        {
            //datagridview nesnesine kitaplar listeleniyor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID", bgl.baglan());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void IslemListele()
        {
            //datagridview nesnesine işlemler listeleniyor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Islemler.ID,Tbl_Islemler.UyeID,Tbl_Islemler.KitapID,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih,Tbl_Kitaplar.Stok FROM Tbl_Islemler inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID", bgl.baglan());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        private void Kitap_Verme_Load(object sender, EventArgs e)
        {
            //listeleme metodları çağrılıyor
            UyeListele();
            KitapListele();
            IslemListele();

            DateTime date = DateTime.Now;
            mskVerilenTarih.Text = date.ToShortDateString();
        }

        private void txtKitapAd_TextChanged(object sender, EventArgs e)
        {
            //seçtiğimiz alana göre sıralama yapma sorguları
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Kitaplar.ID,BarkodNo,KitapAd,YazarAdSoyad,YayinEvi,Tbl_Kitap_Turleri.KitapTuru,KitapSayfa,KitapKonu,Tbl_Sehirler.Sehirler,BaskiTarihi,KitapFiyati,Stok FROM Tbl_Kitaplar INNER JOIN Tbl_Kitap_Turleri on Tbl_Kitap_Turleri.ID=Tbl_Kitaplar.KitapTuruID INNER JOIN Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Kitaplar.BaskiYeriID Where KitapAd like '%" + txtKitapAd.Text+"%'", bgl.baglan());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void mskTC_TextChanged(object sender, EventArgs e)
        {
            //seçtiğimiz alana göre sıralama yapma sorguları
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Uyeler Where TCNO like '%"+mskTC.Text+"%'", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtUyeID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtKitapID.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            label8.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            a = Convert.ToInt16(label8.Text);
            
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtİslemID.Text= dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtUyeID.Text= dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtKitapID.Text= dataGridView3.CurrentRow.Cells[2].Value.ToString();
            mskVerilenTarih.Text= dataGridView3.CurrentRow.Cells[3].Value.ToString();
            mskAlınacakTarih.Text= dataGridView3.CurrentRow.Cells[4].Value.ToString();
            label8.Text= dataGridView3.CurrentRow.Cells[5].Value.ToString();
            a = Convert.ToInt16(label8.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //işlemleri kaydetme sorgusu
            a--;
            label8.Text = a.ToString();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Islemler (UyeID,KitapID,VerilenTarih,AlinanTarih) Values (@p1,@p2,@p3,@p4)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtUyeID.Text);
            komut.Parameters.AddWithValue("@p2",txtKitapID.Text);
            komut.Parameters.AddWithValue("@p3",mskVerilenTarih.Text);
            komut.Parameters.AddWithValue("@p4",mskAlınacakTarih.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();

            SqlCommand komut3 = new SqlCommand("Update Tbl_Kitaplar SET Stok=@p1 Where ID=@p2",bgl.baglan());
            komut3.Parameters.AddWithValue("@p1", label8.Text);
            komut3.Parameters.AddWithValue("@p2",txtKitapID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IslemListele();
            KitapListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bugünün tarihinden 15 gün arttırma
            DateTime date = DateTime.Now.AddDays(15);
            mskAlınacakTarih.Text = date.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bugünün tarihinden 30 gün arttırma
            DateTime date = DateTime.Now.AddDays(30);
            mskAlınacakTarih.Text = date.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //bugünün tarihinden 45 gün arttırma
            DateTime date = DateTime.Now.AddDays(45);
            mskAlınacakTarih.Text = date.ToShortDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bugünün tarihinden 60 gün arttırma
            DateTime date = DateTime.Now.AddDays(60);
            mskAlınacakTarih.Text = date.ToShortDateString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //İşlemler silme sorgusu
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Islemler Where ID=@p1",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtİslemID.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IslemListele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //işlemler güncelleme sorgusu
            SqlCommand komut = new SqlCommand("Update Tbl_Islemler SET UyeID=@p1,KitapID=@p2,VerilenTarih=@p3,AlinanTarih=@p4 Where ID=@p5",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtUyeID.Text);
            komut.Parameters.AddWithValue("@p2",txtKitapID.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(mskVerilenTarih.Text));
            komut.Parameters.AddWithValue("@p4",Convert.ToDateTime(mskAlınacakTarih.Text));
            komut.Parameters.AddWithValue("@p5",txtİslemID.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IslemListele();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //kitap teslim alma sorgusu
            a++;
            label8.Text = a.ToString();
            SqlCommand komut3 = new SqlCommand("Update Tbl_Kitaplar SET Stok=@p1 Where ID=@p2", bgl.baglan());
            komut3.Parameters.AddWithValue("@p1", label8.Text);
            komut3.Parameters.AddWithValue("@p2", txtKitapID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglan().Close();
           
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Islemler Where ID=@p1", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtİslemID.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kitap Teslim Alındı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IslemListele();
            KitapListele();
        }
    }
}
