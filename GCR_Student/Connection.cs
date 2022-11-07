using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCR_Student
{
    class Connection
    {
        static string constr = @"Data Source=BILAL-PC\SQLEXPRESS;Initial Catalog=GCR;Integrated Security=True";
        static SqlConnection con;


        public static SqlConnection GetConnection()
        {
            con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
            return con;

        }
    }
}
