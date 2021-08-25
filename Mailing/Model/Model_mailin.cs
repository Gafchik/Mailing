using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public class Model_mailin
    {
        public static List<MailAddress> _recipients = new List<MailAddress>();
        public MailAddress from;
        public SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", 587);
       
        
    }
}
