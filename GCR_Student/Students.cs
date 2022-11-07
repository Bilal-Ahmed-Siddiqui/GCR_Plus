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
    class Students
    {
        public string Sname { get; set; }
        public string Spassword { get; set; }

        public void Insert(Students s)
        {

            SqlCommand cmd = new SqlCommand(string.Format(
                "insert into Students values ('{0}','{1}')", s.Sname, s.Spassword),
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
        /*
          public void Update(Students s)
          {
              string Update = string.Format("Update Students Set Sname='{0}',Sage={1},Scontact='{2}' Where Sid= {3}",
                  s.Sname, Sage, Scontact, Sid);
              SqlCommand cmd = new SqlCommand(Update, Connection.GetConnection());
              cmd.ExecuteNonQuery();
          }
          public void Delete(int sid)
          {
              SqlCommand cmd = new SqlCommand("Delete  Students where Sid =" +
                  sid, Connection.GetConnection());

              cmd.ExecuteNonQuery();
          }
          public void SearchAll(DataGridView dgv)
          {
              Students s = new Students();
              SqlCommand cmd = new SqlCommand
                  ("select * from Students",
               Connection.GetConnection());
              SqlDataAdapter sda = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              sda.Fill(dt);
              dgv.DataSource = dt;



          }
         */
    }
}
