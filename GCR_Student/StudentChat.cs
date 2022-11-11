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
        TcpClient Client = new TcpClient();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            IPEndPoint point = new IPEndPoint(IPAddress.Loopback, 8002);
            Client = new TcpClient(point);
            Client.Connect(IPAddress.Loopback, 8001);
            Thread t = new Thread(ReadMessage);
            t.Start();
        }

        public void ReadMessage()
        {
            while (true)
            {
                NetworkStream stream = Client.GetStream();
                StreamReader sdr = new StreamReader(stream);
                string msg = sdr.ReadLine();
                txt_Chat.AppendText(Environment.NewLine);
                txt_Chat.AppendText("Teacher: " + msg);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            NetworkStream stream = Client.GetStream();
            StreamWriter sdr = new StreamWriter(stream);
            sdr.WriteLine(txt_Msg.Text);
            sdr.Flush();
            txt_Chat.AppendText(Environment.NewLine);
            txt_Chat.AppendText("Student: " + txt_Msg.Text);
            txt_Msg.Clear();
        }
    }
}
