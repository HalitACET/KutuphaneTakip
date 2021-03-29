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
            KitapListesi frm = new KitapListesi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
    }
}
