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
    public partial class MakeAnnoucement : Form
    {
        public MakeAnnoucement()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            TeacherPanel tp = new TeacherPanel();
            this.Hide();
            tp.Show();
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text != "" && txt_Description.Text != "")
            {
                Posts p1 = new Posts();
                p1.title = txt_Title.Text;
                p1.description = txt_Description.Text;
                p1.Insert(p1);

                MessageBox.Show("Published!!");
            }
            else
            {
                MessageBox.Show("Please Provide All Details!");
            }
        }
    }
}
