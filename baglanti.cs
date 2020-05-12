using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class baglanti
    {
        public SqlConnection baglantim()
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-EH5DFEE; Integrated Security=true; Database=paradise_stok");

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }

    
   
}
