﻿using System;
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
    public partial class Admin_ekle : Form
    {
        public Admin_ekle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        public void adminlistele()
        {
            //admin tablosundan verileri listeleyen metod
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Adminler",bgl.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Admin_ekle_Load(object sender, EventArgs e)
        {
            adminlistele();
        }
        public void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTC.Text = "";
            mskTel.Text = "";
            txtEposta.Text = "";
            txtKullanici.Text = "";
            txtSifre.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string sifre = txtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string soyad = txtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string tc = mskTC.Text;
            byte[] tcdizi = ASCIIEncoding.ASCII.GetBytes(tc);
            string tcsifre = Convert.ToBase64String(tcdizi);

            string tel = mskTel.Text;
            byte[] teldizi = ASCIIEncoding.ASCII.GetBytes(tel);
            string telsifre = Convert.ToBase64String(teldizi);

            string eposta = txtEposta.Text;
            byte[] epostadizi = ASCIIEncoding.ASCII.GetBytes(eposta);
            string epostasifre = Convert.ToBase64String(epostadizi);

            string kullanici = txtKullanici.Text;
            byte[] kullanicidizi = ASCIIEncoding.ASCII.GetBytes(kullanici);
            string kullanicisifre = Convert.ToBase64String(kullanicidizi);



            //admin ekleme sorgusu
            SqlCommand komut = new SqlCommand("Insert Into Tbl_Adminler (Adi,Soyadi,TCNO,Telefon,Eposta,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", tcsifre);
            komut.Parameters.AddWithValue("@p4", telsifre);
            komut.Parameters.AddWithValue("@p5", epostasifre);
            komut.Parameters.AddWithValue("@p6", kullanicisifre);
            komut.Parameters.AddWithValue("@p7", sifresifre);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminlistele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //admin silme sorgusu
            SqlCommand komut = new SqlCommand("Delete from Tbl_Adminler Where ID=@p1",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kayıt Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminlistele();
            temizle();
               
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //admin güncelleme sorgusu
            SqlCommand komut = new SqlCommand("Update Tbl_Adminler Set Adi=@p1,Soyadi=@p2,TCNO=@p3,Telefon=@p4,Eposta=@p5,KullaniciAdi=@p6,Sifre=@p7 Where ID=@p8",bgl.baglan());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtEposta.Text);
            komut.Parameters.AddWithValue("@p6", txtKullanici.Text);
            komut.Parameters.AddWithValue("@p7", txtSifre.Text);
            komut.Parameters.AddWithValue("@p8",txtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminlistele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview nesnesinde tıkladığımız hücre ler textboxlara taşınıyor
            txtID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mskTC.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskTel.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEposta.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKullanici.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSifre.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifrecozum = txtSifre.Text;
            byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            string sifreverisi = ASCIIEncoding.ASCII.GetString(sifrecozumdizi);
            label7.Text = sifreverisi;
           
        }
    }
}
