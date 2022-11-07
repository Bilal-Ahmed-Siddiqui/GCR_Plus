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
    class Posts
    {
        public string title { get; set; }
        public string description { get; set; }

        public void Insert(Posts p)
        {

            SqlCommand cmd = new SqlCommand(string.Format(
                "insert into Posts values ('{0}','{1}')", p.title, p.description),
            Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public bool Find(string _name, string _pass)
        {
            Students s = new Students();
            SqlCommand cmd = new SqlCommand(string.Format(
                "select * from Students where name = '{0}' and password = '{1}'", _name, _pass),
                Connection.GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            bool check = dr.HasRows;
            dr.Close();
            return check;
        }
    }
}
