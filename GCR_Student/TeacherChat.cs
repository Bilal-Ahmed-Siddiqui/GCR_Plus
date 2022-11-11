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
    public partial class TeacherChat : Form
    {
        public TeacherChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherPanel tp = new TeacherPanel();
            this.Hide();
            tp.Show();
        }
    }
}
