using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboboxsearch
{
    public class database
    {
        string constr = ConfigurationManager.ConnectionStrings["comboboxsearch.Properties.Settings.StudentRecordConnectionString"].ConnectionString;

        public DataTable getstates()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(constr);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("usp_states", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            return dt;
        }
    }
}
