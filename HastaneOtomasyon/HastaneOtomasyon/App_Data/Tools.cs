using System.Configuration;
using System.Data.SqlClient;

namespace HastaneOtomasyon.App_Data
{
    class Tools
    {
        //Singletion Pattern
        //SQL server baglanti nesnesi

        //B1 ID olacak şekilde White Box testi uygulandı.
        private static SqlConnection _baglanti;
        public static SqlConnection Baglanti
        {
            get
            {
                _baglanti = _baglanti ??
                 new SqlConnection(ConfigurationManager.
                 ConnectionStrings["localBaglanti"].ConnectionString);
                return _baglanti;
            }
        }
    }
}
