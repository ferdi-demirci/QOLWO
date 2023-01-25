using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QOLWO
{
    class VeritabaniBaglantisi
    {
        public SqlConnection baglan;
        public VeritabaniBaglantisi()
        {
            this.baglan = new SqlConnection("Data Source=" + Ayarlar.Default.server.ToString() + ";User Id=" + Ayarlar.Default.kullaniciadi.ToString() + ";password=" + Ayarlar.Default.sifre.ToString() + ";Initial Catalog=" + Ayarlar.Default.database.ToString() );


        }
    }
}
