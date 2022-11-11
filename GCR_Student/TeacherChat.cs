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
        List<TcpClient> Clients = new List<TcpClient>();
        TcpListener server;
        private void button2_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            server = new TcpListener(IPAddress.Loopback, 8001);
            server.Start(10);
            Thread t2 = new Thread(AcceptClient);
            t2.Start();
        }

        public void AcceptClient()
        {
            while (true)
            {
                TcpClient c = server.AcceptTcpClient();
                Clients.Add(c);
                Thread t = new Thread(asd => ReadMessage(c));
                t.Start();

            }
        }

        public void ReadMessage(TcpClient client)
        {
            while (true)
            {
                NetworkStream stream = client.GetStream();
                StreamReader sdr = new StreamReader(stream);
                string msg = sdr.ReadLine();
                txt_Chat.AppendText(Environment.NewLine);
                txt_Chat.AppendText("Student: " + msg);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (var item in Clients)
            {
                txt_Chat.AppendText(Environment.NewLine);
                txt_Chat.AppendText("Teacher: " + txt_Msg.Text);
                NetworkStream stream = item.GetStream();
                StreamWriter sdr = new StreamWriter(stream);
                sdr.WriteLine(txt_Msg.Text);
                sdr.Flush();
                txt_Msg.Clear();
            }
        }
    }
}
