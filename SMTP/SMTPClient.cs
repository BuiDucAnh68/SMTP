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
using System.Net.Security;
namespace SMTP
{
    public partial class SMTPClient : Form
    {
        TcpClient tcpClient;
        StreamReader sr;
        StreamWriter sw;
        Thread listenThread;
        public SMTPClient()
        {
            InitializeComponent();
        }

        private void Client(string input)
        {
            string text = "C:" + input + "\n";
            rTB_BoxGet.Text += text;
        }
        private void Server(string input)
        {
            string text = "S: " + input + "\n";
            rTB_BoxSend.Text += text;
        }
        private string StringBase64(string input)
        {
            byte[] inputByte = ASCIIEncoding.ASCII.GetBytes(input);
            string encodeinput = Convert.ToBase64String(inputByte);
            return encodeinput;
        }
        
        private void AuthenRespond()
        {
            while(true)
            {
                string mess = "";
                mess = sr.ReadLine();
                if(string.IsNullOrEmpty(mess))
                {
                    tcpClient.Close();
                    break;

                }
                Server(mess);
                
            }
        }
        
        private void AuthenciationMessage()
        {
            rTB_BoxGet.Clear();
            rTB_BoxSend.Clear();
            tcpClient = new TcpClient();
            string host = "smtp.gmail.com";
            tcpClient.Connect(host, 587);//2 port để kết nối với GMAIL 465,587 và đây em dùng port 587 cho TCP Client để chung port của SMTP client
            //Nếu ở đây em sử dụng Port 465 nó phải xác thực thành công cho máy và rất khó cho máy khác accept thành công
            //SslStream ssl = new SslStream(tcpClient.GetStream());
            //ssl.AuthenticateAsClient("smtp.gmail.com");
            sr = new StreamReader(tcpClient.GetStream());
            sw = new StreamWriter(tcpClient.GetStream());
            //Lấy đuôi sau @ của tài khoản gửi và nhận để lấy domain của EHLO  
            int index = txt_from.Text.Trim().IndexOf('@');
            string domain = txt_from.Text.Trim().Substring(index + 1);
            //Bắt đầu lắng nghe Server 
            CheckForIllegalCrossThreadCalls = false;
            listenThread = new Thread(new ThreadStart(AuthenRespond));
            listenThread.IsBackground = true;
            listenThread.Start();
            try
            {
                //Chạy từng câu lệnh để Client bắt đầu trả về theo từng dòng lệnh để gửi đến Server đã bắt đầu gửi vào richTextBox
                string data = "EHLO " + domain;
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "AUTH LOGIN";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = StringBase64(txt_from.Text);
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = StringBase64(txt_password.Text);
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "MAIL FROM:<" + txt_from.Text + ">";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "RCPT TO:<" + txt_To.Text + ">";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "DATA";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "Subject: " + txt_subject.Text;
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "FROM:<" + txt_from.Text + ">";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                data = "TO:<" + txt_To.Text + ">";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                Client("");
                sw.WriteLine("");
                sw.Flush();

                data = richTB_message.Text;
                //Nếu Body chứa xuống dòng thì sẽ nhảy xuống một cái C: để in ra message đó còn nếu không thì chỉ hiện trên một dòng
                if (data.Contains("\n"))
                {
                    
                    string[] newData = data.Split('\n');
                    foreach (string stringLine in newData)
                    {
                        Client(stringLine);
                        sw.WriteLine(stringLine);
                        sw.Flush();
                    }
                }
                else
                {
                    Client(data);
                    sw.WriteLine(data);
                    sw.Flush();
                }

                

                Client(".");
                sw.WriteLine(".");
                sw.Flush();

                data = "QUIT";
                Client(data);
                sw.WriteLine(data);
                sw.Flush();

                
            } 
            
            
            catch(Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi" + ex.ToString() + "Vui lòng thử lại");
            }
        }
        private void Connect_Gmail()
        {

            string mailfrom = txt_from.Text.ToString().Trim();
            string mailto = txt_To.Text.ToString().Trim();
            string password = txt_password.Text.ToString().Trim();
            string subject = txt_subject.Text.ToString().Trim();
            string body = richTB_message.Text.ToString();
            
            
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailfrom, password),
            };

            
            using (MailMessage message = new MailMessage())
            { 
                message.From = new MailAddress(mailfrom);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;
                message.To.Add(mailto);
                //Chọn các file cần gửi nếu không gửi file thì không sử dụng phương thức gửi này
                if (rTB_File.Text != "")
                {
                    string[] attachment = rTB_File.Text.Split('\n');
                    foreach (string attachfile in attachment)
                    {
                        if(attachfile != "")
                            message.Attachments.Add(new Attachment(attachfile));
                    }
                    
                }
                try
                {
                    client.Send(message);
                    MessageBox.Show("Gửi mail thành công", "Success");
                    rTB_File.Text = "";
                    richTB_message.Text = "";
                    txt_subject.Text = "";
                }
                catch
                {
                    MessageBox.Show("Gửi mail thất bại", "Error");
                }
            }
        }
        
           
        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(txt_from.Text)) && (!String.IsNullOrEmpty(txt_password.Text)) && (!String.IsNullOrEmpty(txt_To.Text)))
            {
                AuthenciationMessage();
                Connect_Gmail();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi gửi!", "Lỗi");
            }    

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

        private void btn_attachment_Click(object sender, EventArgs e)
        {
            //Gửi tối đa là 24 MB cho tổng file đính kèm và hiện tên lên richTextBox
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            rTB_File.Text += ofd.FileName + "\n"; 
        }

       
    }
}
