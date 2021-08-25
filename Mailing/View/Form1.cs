using Mailing.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailing
{
    public partial class Form1 : Form
    {
        public Model_mailin _mailin;
        public Form1()
        {
            InitializeComponent();
            add_recipient.Click += Add_recipient_Click;
            del_recipient.Click += Del_recipient_Click;
            send_btn.Click += Send_btn_Click;
            count_mail_numeric.Value = 1;
            count_mail_numeric.Minimum = 1;
            _mailin = new Model_mailin();
            Init_recipients_LB();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if(login.Text==null&&login.Text==string.Empty)
            {
                MessageBox.Show("Ошибка", "не указан логин");
                return;
            }
            if (password.Text == null && password.Text == string.Empty)
            {
                MessageBox.Show("Ошибка", "не указан пароль");
                return;
            }
            if (thema_mail.Text == null && thema_mail.Text == string.Empty)
            {
                MessageBox.Show("Ошибка", "не указана тема сообщения");
                return;
            }
            if (text_mail.Text == null && text_mail.Text == string.Empty)
            {
                MessageBox.Show("Ошибка", "не указан текст");
                return;
            }
            if (Model_mailin._recipients.Count==0)
            {
                MessageBox.Show("Ошибка", "некому отправлять");
                return;
            }
            try { _mailin.from = new MailAddress(login.Text); }
            catch (Exception ex) { MessageBox.Show("Что-то не так с логином изи паролем", "ой");  }
            SendAsync();

        }
        public async void SendAsync()
        {
            for (int i = 0; i < count_mail_numeric.Value; i++)
            {
                foreach (var item in Model_mailin._recipients)
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            MailMessage mailMessage = new MailMessage(_mailin.from, item);
                            mailMessage.Subject = thema_mail.Text;
                            mailMessage.Body = text_mail.Text;
                            mailMessage.IsBodyHtml = IsHTML.Checked;
                            _mailin._smtpClient.Credentials = new NetworkCredential(login.Text, password.Text);
                            _mailin._smtpClient.EnableSsl = true;
                            _mailin._smtpClient.Send(mailMessage);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Что-то не так с логином изи паролем","ой");
                            return;
                        }
                        
                    });
                } 
            }
            MessageBox.Show("Успех", "Все разослано");
        }
        public void Init_recipients_LB()
        {
            recipients_LB.Items.Clear();
            Model_mailin._recipients.ForEach(i => recipients_LB.Items.Add(i.Address));
        }
   
        private void Del_recipient_Click(object sender, EventArgs e)
        {
            if (recipients_LB.SelectedItem == null)
                return;
            recipients_LB.Items.RemoveAt(recipients_LB.SelectedIndex);
            MessageBox.Show("Успех", "Удалено");
            Init_recipients_LB();
        }

        private void Add_recipient_Click(object sender, EventArgs e)
        {
            new Recipients_View().ShowDialog();
            Init_recipients_LB();
        }
    }
}
