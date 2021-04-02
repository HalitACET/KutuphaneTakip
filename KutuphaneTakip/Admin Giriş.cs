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
    public partial class Admin_Giriş : Form
    {
        public Admin_Giriş()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Adminler Where KullaniciAdi=@p1 and Sifre=@p2",bgl.baglan());
            komut.Parameters.AddWithValue("@p1",txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Admin_ekle frm = new Admin_ekle();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin Bulunamadı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
