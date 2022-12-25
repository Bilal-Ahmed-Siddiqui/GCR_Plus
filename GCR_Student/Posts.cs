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
        public DateTime dt { get; set; }
        public int count { get; set; }

        public void Insert(Posts p)
        {
            p.dt = DateTime.Now;
            SqlCommand cmd = new SqlCommand(string.Format(
                "insert into Posts values ('{0}','{1}', '{2}')", p.title, p.description,p.dt),
            Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }
        public void Search(int id)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(Id) FROM Posts",
             Connection.GetConnection());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            count = Int32.Parse(dr1[0].ToString());
            dr1.Close();

            if (id <= count)
            {
                SqlCommand cmd2 = new SqlCommand("select * from Posts where Id =" + id,
             Connection.GetConnection());

                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();

                title = dr2[1].ToString();
                description = dr2[2].ToString();
                dt = (DateTime)dr2[3];
                dr2.Close();
            }            
        }

        public static int Count()
        {
            int c;
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(Id) FROM Posts",
             Connection.GetConnection());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            c = Int32.Parse(dr1[0].ToString());
            dr1.Close();
            return c;
        }
    }
}
