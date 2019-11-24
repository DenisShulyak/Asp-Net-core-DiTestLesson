using DiTestLesson.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DiTestLesson.Servises
{
    public class EmailSenderServies : IEmailSenderServies
    {
        public Task SendEmail(EmailMessageDTO emailMessage)
        {
           
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("denshufly@mail.ru", "Tom");
                // кому отправляем
                MailAddress to = new MailAddress(emailMessage.To);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = emailMessage.Title;
                // текст письма
                m.Body = emailMessage.Text;
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("denshufly@mail.ru", "DeNiS300402");
                smtp.EnableSsl = true;
            //return smtp.SendAsync(, m.To,emailMessage.Title,emailMessage.Text);
                return smtp.SendMailAsync(m);
                //еще какие то настройки
                //return smtp.SendMailAsync("denshufly@mail.ru", emailMessage.To, emailMessage.Title, emailMessage.Text);
            
        }
    }
}
