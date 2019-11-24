using DiTestLesson.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiTestLesson.Servises
{
   public interface IEmailSenderServies
    {
        public Task SendEmail(EmailMessageDTO emailMessage);
    }
}
