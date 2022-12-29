using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace GCR_Student
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }
        MailMessage mm = new MailMessage();

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (txt_body.Text != "" && txt_from.Text != "" && txt_Subject.Text != "" && txt_to.Text != "") {
                try
                {
                    SmtpClient sm = new SmtpClient("smtp.gmail.com");
                    mm.To.Add(txt_to.Text);
                    mm.From = new MailAddress(txt_from.Text);
                    mm.Subject = txt_Subject.Text;
                    mm.Body = txt_body.Text;
                    sm.Port = 587;
                    sm.Credentials = new System.Net.NetworkCredential("itsannatorres01@gmail.com", "uwibnjrqevprnvxw");
                    //sm.Credentials = new System.Net.NetworkCredential(txt_mail.Text, txt_pass.Text);
                    sm.EnableSsl = true;
                    sm.Send(mm);

                    MessageBox.Show("Mail Sent");
                    txt_body.Text = "";
                    txt_from.Text = "";
                    txt_Subject.Text = "";
                    txt_to.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Provide All Details!");
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
        int count = 0;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                count++;
                txt_pass.PasswordChar = '\0';
                btn_Show.Text = "Hide";
            }
            else
            {
                count++;
                txt_pass.PasswordChar = '*';
                btn_Show.Text = "Show";
            }

        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            
        }
    }
}
