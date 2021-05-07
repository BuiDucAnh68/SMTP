using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace SMTP
{
    public partial class SMTPClient : Form
    {
        
        
        public SMTPClient()
        {
            InitializeComponent();
        }
        private void Connect_Gmail()
        {
            
            string mailfrom = txt_from.Text.ToString().Trim();
            string mailto = txt_To.Text.ToString().Trim();
            string password = txt_password.Text.ToString().Trim();
            string subject = txt_subject.Text.ToString().Trim();
            string body = richTB_message.Text.ToString().Trim();
            SmtpClient client = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailfrom, password),
            };
            using (var message = new MailMessage(mailfrom, mailto)
            {
                Subject = subject,
                Body = body
            })
            {
                client.Send(message);
            }
            



        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Connect_Gmail();
                MessageBox.Show("Send message to gmail to public","Success");
            }
            catch
            {
                MessageBox.Show("Failure Message to Gmail", "Error");
            }
        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked==true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
       

        private void rTB_TCP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
