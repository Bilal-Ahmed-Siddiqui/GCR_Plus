using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using SimpleTCP;

namespace GCR_Student
{
    public partial class StudentChat : Form
    {
        public StudentChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPanel sp = new StudentPanel();
            this.Hide();
            sp.Show();
        }
        SimpleTcpClient client;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            client.Connect("192.168.18.74", 80);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            client.WriteLine(string.Format("Student: {0}", txt_Msg.Text));
        }

        private void StudentChat_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataRecieved;
            txt_Msg.Focus();
        }

        public void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            txt_Chat.Invoke((MethodInvoker)delegate ()
            {
                txt_Chat.Text += e.MessageString;
                txt_Chat.Text += Environment.NewLine;
            });
        }
    }
}
