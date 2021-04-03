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
            //İşlemler,Kitaplar,Uyeler tablosu birleştirilip datagridwiew nesnesinde listeleniyor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID", bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kitap listesi formu gösteriliyor
            KitapListesi frm = new KitapListesi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //okuyucu formu gösteriliyor
            Okuyucu frm = new Okuyucu();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //kitap ekleme formu gösterilior
            Kitap_Ekleme_Formu frm = new Kitap_Ekleme_Formu();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //program sonlandırılıyor
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //kitap verme formu çağrılıyor
            Kitap_Verme frm = new Kitap_Verme();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //verilen kitaplar formu çağrılıyor
            Verilen_Kitaplar frm = new Verilen_Kitaplar();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tarihi geçenler formu çağrılıyor
            Tarihi_Geçenler frm = new Tarihi_Geçenler();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //İşlemler,Kitaplar,Uyeler tablosu birleştirilip datagridwiew nesnesinde listeleniyor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID",bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtBarkodNo.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTCNO.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSecilenKitap.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAdSoyad.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString()+" "+ dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçtiğimiz alana göre sıralama yapma sorguları
            if (comboBox1.SelectedIndex==0)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Kitaplar.KitapAd = '" + textBox5.Text + "'", bgl.baglan());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.SelectedIndex==1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Uyeler.TCNO = '" + textBox5.Text + "'", bgl.baglan());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.SelectedIndex==2)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Kitaplar.BarkodNo = '" + textBox5.Text + "'", bgl.baglan());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.SelectedIndex==3)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Uyeler.Adi = '" + textBox5.Text + "'", bgl.baglan());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //seçilen alana göre yapılan sorgular
            if (comboBox1.SelectedIndex==0)
            {
                DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Kitaplar.KitapAd like  '%" + textBox5.Text + "%'", bgl.baglan());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            }
            if (comboBox1.SelectedIndex==1)
            {
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Uyeler.TCNO like '%" + textBox5.Text + "%'", bgl.baglan());
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            if (comboBox1.SelectedIndex==2)
            {
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Kitaplar.BarkodNo like '%" + textBox5.Text + "%'", bgl.baglan());
                da3.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            if (comboBox1.SelectedIndex==3)
            {
                DataTable dt4 = new DataTable();
                SqlDataAdapter da4 = new SqlDataAdapter("Select Tbl_Islemler.ID,Tbl_Uyeler.TCNO,Tbl_Uyeler.Adi,Tbl_Uyeler.Soyadi,Tbl_Kitaplar.BarkodNo,Tbl_Kitaplar.kitapAd,Tbl_Kitaplar.YazarAdSoyad,Tbl_Uyeler.Telefon,Tbl_Uyeler.Eposta,Tbl_Islemler.VerilenTarih,Tbl_Islemler.AlinanTarih from Tbl_Islemler inner join Tbl_Uyeler on Tbl_Uyeler.ID=Tbl_Islemler.UyeID inner join Tbl_Kitaplar on Tbl_Kitaplar.ID=Tbl_Islemler.KitapID Where Tbl_Uyeler.Adi like '%" + textBox5.Text + "%'", bgl.baglan());
                da4.Fill(dt4);
                dataGridView1.DataSource = dt4;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //admin giriş formu çağrılıyor
            Admin_Giriş frm = new Admin_Giriş();
            frm.Show();
        }
    }
}
