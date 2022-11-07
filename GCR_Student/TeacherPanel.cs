using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCR_Student
{
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_AddStudents_Click(object sender, EventArgs e)
        {
            AddStudent ad = new AddStudent();
            this.Hide();
            ad.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MakeAnnoucement ma = new MakeAnnoucement();
            this.Hide();
            ma.Show();
        }
    }
}
