using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HCG_N10
{
    class ketnoi
    {
        SqlConnection con;

        public ketnoi()
        {
            con = new SqlConnection(@"Data Source=FANGLEEPC;Initial Catalog=expert_system_gui;Integrated Security=True;");
            con.Open();

        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;

        }
        public void thuchien(string sql)
        {
            SqlCommand com;
            com = con.CreateCommand();
            com.CommandText = sql;
            com.ExecuteNonQuery();
            com.Dispose();
        }
    }
}
