using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace GCR_Student
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Password.Text != "")
            {
                if (!Regex.IsMatch(txt_Name.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("User Name Can only contain Alphabets", "Invalid");
                    txt_Name.Text = "";
                    txt_Name.Focus();
                }
                else
                {
                    Students s1 = new Students();
                    s1.Sname = txt_Name.Text;
                    s1.Spassword = txt_Password.Text;
                    s1.Insert(s1);
                    MessageBox.Show("Student Addded Successfully");
                    txt_Name.Text = "";
                    txt_Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            TeacherPanel tp = new TeacherPanel();
            this.Hide();
            tp.Show();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
