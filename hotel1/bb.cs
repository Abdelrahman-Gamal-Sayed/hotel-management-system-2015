using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace hotel1
{

    class bb
    {
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(path);
        public static string path = @"Data Source=FLULLOHTXNZJ5I4\S2008;Initial Catalog=resturant;Integrated Security=True";
      
        SqlCommand d = new SqlCommand();
        public void insert_update_delete(string sql)
        {

            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();

            conn.Close();
        }
        public void setcommand(string sql)
        {
            d.Connection = conn;
            d.CommandText = sql;
        }
        public DataTable select(String sql)
        {
            DataTable da = new DataTable();
            setcommand(sql);
            conn.Open();
            da.Load(d.ExecuteReader());
            conn.Close();

            return da;
            
         
           
        }
    }
}
