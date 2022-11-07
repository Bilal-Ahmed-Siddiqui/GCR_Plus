using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCR_Student
{
    class Teachers
    {
        public string Tname { get; set; }
        public string Tpassword { get; set; }

        public bool Find(string _name, string _pass)
        {
            Teachers s = new Teachers();
            SqlCommand cmd = new SqlCommand(string.Format(
                "select * from Teachers where email = '{0}' and password = '{1}'", _name, _pass),
                Connection.GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            bool check = dr.HasRows;
            dr.Close();
            return check;
        }
    }
}
