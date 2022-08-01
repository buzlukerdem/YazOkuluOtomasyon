using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    // CRUD ISLEMERININ YAPILDIGI KATMAN
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-HJL1ER0;Initial Catalog=DB_YazOkuluSistemi;Integrated Security=True");
    }
}
