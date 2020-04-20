using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dataaccesslayer
{
    class baglanti
    {
        public static SqlConnection bag = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_personel;Integrated Security=True");
    }
}
