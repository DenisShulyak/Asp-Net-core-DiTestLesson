using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiTestLesson.Servises
{
    public interface ISmsSenderServies
    {
        public Task SendSms(string phoneNumber);
    }
}
