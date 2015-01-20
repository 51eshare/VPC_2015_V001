using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using Entity;


namespace Service
{
    public static class SMTP
    {
        static string smtpserver = string.Empty;
        static string uname = string.Empty;
        static string upw = string.Empty;
        static int smtpport = 25;
        static bool ssl = false;
        static SMTP()
        {
            smtpserver = ConfigurationManager.AppSettings["HostIP"];
            smtpport = Int32.Parse(ConfigurationManager.AppSettings["smtpport"]);
            uname = ConfigurationManager.AppSettings["username"];
            upw = ConfigurationManager.AppSettings["password"];
            ssl = ConfigurationManager.AppSettings["ssl"].Equals("1");
        }

        #region 发送邮件
        public static bool Send(t_Email email)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(uname);
            foreach (string item in email.To)
            {
                message.To.Add(item);
            }
            message.Subject = email.Subject;
            if (email.CC.Any())
                foreach (string cc in email.CC)
                {
                    message.CC.Add(cc);
                }
            if(email.Bcc.Any())
                foreach (string item in email.Bcc)
                {
                    message.Bcc.Add(item);
                }
            message.IsBodyHtml = true;
            message.BodyEncoding = Encoding.UTF8;
            message.Body = email.Body;
            message.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient(smtpserver,smtpport);
            client.Credentials = new System.Net.NetworkCredential(uname,upw);
            if (ssl)
                client.EnableSsl = true;
            try
            {
                client.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion 
    }
}
