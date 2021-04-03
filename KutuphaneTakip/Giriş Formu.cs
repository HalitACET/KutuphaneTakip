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
    public partial class Giriş_Formu : Form
    {
        public Giriş_Formu()
        {
            InitializeComponent();
        }
        //baglanti sınıfı çağrıldı
        Baglanti bgl = new Baglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Giriş yapmak için gerekli olan bilgiler sorgulanıyor
            SqlCommand komut = new SqlCommand("SELECT * From Tbl_Adminler Where KullaniciAdi=@p1 and Sifre=@p2",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt bulunamadı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
