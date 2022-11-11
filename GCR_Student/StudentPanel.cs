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
    public partial class StudentPanel : Form
    {
        protected int counter = 1;

        public StudentPanel()
        {
            InitializeComponent();
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

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Posts p1 = new Posts();
            counter++;
            p1.Search(counter);
            if (counter <= p1.count)
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

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            Posts p1 = new Posts();
            p1.Search(counter);
            lbl_Title.Text = p1.title.ToString();
            lbl_Description.Text = p1.description.ToString();
            lbl_Datetime.Text = p1.dt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentChat sc = new StudentChat();
            this.Hide();
            sc.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
