using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace KutuphaneTakip
{
    class Baglanti
    {
        //Her yerden ulaşmak için bağlantı sınıfından metot kullanıldı
        public SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6CRR4TF\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
