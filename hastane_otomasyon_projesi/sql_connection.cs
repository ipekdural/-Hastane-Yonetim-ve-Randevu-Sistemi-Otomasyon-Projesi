using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_otomasyon_projesi
{
    internal class sql_connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("");
            conn.Open();
            return conn;
        }

    }
}
