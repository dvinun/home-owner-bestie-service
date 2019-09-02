using Common.DataStructures;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace HomeOwnerBestie.Common
{
    public static class Utils
    {
        public static bool SendEmail(EmailEnvelop emailEnvelop, EmailConfig emailConfig)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(emailConfig.Smtp);

                mail.From = new MailAddress(emailEnvelop.From);
                mail.To.Add(emailEnvelop.To);
                mail.Subject = emailEnvelop.Subject;

                mail.IsBodyHtml = true;
                mail.Body = emailEnvelop.Body;

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = emailConfig.Port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(emailConfig.UserName, emailConfig.Password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
