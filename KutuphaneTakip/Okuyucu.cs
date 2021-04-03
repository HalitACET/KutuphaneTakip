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
    public partial class Okuyucu : Form
    {
        public Okuyucu()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        public void listele()
        {
            //Üyeler tablosu datagridview nesnesinde listelendi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Uyeler.ID,TCNO,Adi,Soyadi,Sifre,Tbl_Sehirler.Sehirler,DogumTarihi,Telefon,Eposta,UyelikTarihi,Cinsiyet,Adres FROM Tbl_Uyeler inner join Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Uyeler.DogumYeriID", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }
        private void Okuyucu_Load(object sender, EventArgs e)
        {
            //bugünün tarihi otomatik olarak üyelik tarihine gelior ve veritabanından şehirler combobox a aktarılıyor
            DateTime date = DateTime.Now;
            listele();
            mskUylktrh.Text = date.ToShortDateString();
            SqlCommand komut = new SqlCommand("SELECT Sehirler FROM Tbl_Sehirler",bgl.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDgm.Items.Add(dr[0]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Üyeler tablosuna veri kaydetme sorgusu
            int a = Convert.ToInt16((+1) + cmbDgm.SelectedIndex);

            SqlCommand komut = new SqlCommand("insert into Tbl_Uyeler (TCNO,Adi,Soyadi,DogumYeriID,DogumTarihi,Telefon,Eposta,UyelikTarihi,Cinsiyet,Adres,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", a);
            komut.Parameters.AddWithValue("@p5", Convert.ToDateTime(mskDgmtrh.Text).Date);
            komut.Parameters.AddWithValue("@p6", mskTel.Text);
            komut.Parameters.AddWithValue("@p7", txtEposta.Text);
            komut.Parameters.AddWithValue("@p8", Convert.ToDateTime(mskUylktrh.Text).Date);
            komut.Parameters.AddWithValue("@p9", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p10", rchtxtAdres.Text);
            komut.Parameters.AddWithValue("@p11",txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //Uyeler tablosuna veri güncelleme sorgusu
            int a = Convert.ToInt16((+1) + cmbDgm.SelectedIndex);

            SqlCommand komut = new SqlCommand("UPDATE Tbl_Uyeler SET TCNO=@p1,Adi=@p2,Soyadi=@p3,DogumYeriID=@p4,DogumTarihi=@p5,Telefon=@p6,Eposta=@p7,UyelikTarihi=@p8,Cinsiyet=@p9,Adres=@p10,Sifre=@p12 Where ID=@p11", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", a);
            komut.Parameters.AddWithValue("@p5", Convert.ToDateTime(mskDgmtrh.Text).Date);
            komut.Parameters.AddWithValue("@p6", mskTel.Text);
            komut.Parameters.AddWithValue("@p7", txtEposta.Text);
            komut.Parameters.AddWithValue("@p8", Convert.ToDateTime(mskUylktrh.Text).Date);
            komut.Parameters.AddWithValue("@p9", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p10", rchtxtAdres.Text);
            komut.Parameters.AddWithValue("@p11",textBox1.Text);
            komut.Parameters.AddWithValue("@p12",txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            textBox1.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mskTC.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSifre.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbDgm.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mskDgmtrh.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mskTel.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtEposta.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mskUylktrh.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbCinsiyet.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();
            rchtxtAdres.Text= dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Üyeler tablosundaki verileri silen sorgu
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Uyeler WHERE ID=@p1",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
