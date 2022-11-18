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
        //static string constr = @"Data Source=BILAL-PC\SQLEXPRESS;Initial Catalog=GCR;Integrated Security=True";
        static string constr = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=bilalahmedsiddiqui_;User Id=bilalahmedsiddiqui_;Password=iamdoingbscs123;";

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
