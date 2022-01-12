using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace SwissConnections
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage(tbxGmailEmail.Text.Trim(), tbxToEmail.Text.Trim()))
            {
                mm.Subject = tbxSubject.Text;
                mm.Body = tbxBody.Text;
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(tbxGmailEmail.Text.Trim(), tbxPassword.Text.Trim());
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                MessageBox.Show("Email sent.", "Message");
            }
        }
    }
}
