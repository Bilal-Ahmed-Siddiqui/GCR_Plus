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
        protected int counter = 1;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TeacherPanel_Load(object sender, EventArgs e)
        {
            Posts p1 = new Posts();
            p1.Search(counter);
            lbl_Title.Text = p1.title.ToString();
            lbl_Description.Text = p1.description.ToString();
            lbl_Datetime.Text = p1.dt.ToString();

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Posts p1 = new Posts();
            counter++;
            p1.Search(counter);
            if(counter <= p1.count)
            {
                lbl_Title.Text = p1.title.ToString();
                lbl_Description.Text = p1.description.ToString();
                lbl_Datetime.Text = p1.dt.ToString();
            }
            else
            {
                MessageBox.Show("No Next Post");
                counter--;
            }
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                MessageBox.Show("No Previous Post");
            }
            else
            {
                Posts p1 = new Posts();
                counter--;
                p1.Search(counter);
                lbl_Title.Text = p1.title.ToString();
                lbl_Description.Text = p1.description.ToString();
                lbl_Datetime.Text = p1.dt.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Datetime_Click(object sender, EventArgs e)
        {

        }
    }
}
