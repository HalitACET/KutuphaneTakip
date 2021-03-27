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
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Uyeler",bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();
        }
        private void Okuyucu_Load(object sender, EventArgs e)
        {
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
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Uyeler (TCNO,Adi,Soyadi,DogumYeriID,DogumTarihi,Telefon,Eposta,UyelikTarihi,Cinsiyet,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtAd.Text);
            komut.Parameters.AddWithValue("@p3",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4",cmbDgm.Text);
            komut.Parameters.AddWithValue("@p5",mskDgmtrh.Text);
            komut.Parameters.AddWithValue("@p6",mskTel.Text);
            komut.Parameters.AddWithValue("@p7",txtEposta.Text);
            komut.Parameters.AddWithValue("@p8",mskUylktrh.Text);
            komut.Parameters.AddWithValue("@p9",cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p10",rchtxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi...");
            listele();


            
            
        }
    }
}
