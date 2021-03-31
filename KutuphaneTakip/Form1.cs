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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kitaplar", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            KitapListesi frm = new KitapListesi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tbl_Uyeler.ID,TCNO,Adi,Soyadi,Tbl_Sehirler.Sehirler,DogumTarihi,Telefon,Eposta,UyelikTarihi,Cinsiyet,Adres FROM Tbl_Uyeler inner join Tbl_Sehirler on Tbl_Sehirler.ID=Tbl_Uyeler.DogumYeriID", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglan().Close();

            Okuyucu frm = new Okuyucu();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kitap_Ekleme_Formu frm = new Kitap_Ekleme_Formu();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitap_Verme frm = new Kitap_Verme();
            frm.Show();
        }
    }
}
