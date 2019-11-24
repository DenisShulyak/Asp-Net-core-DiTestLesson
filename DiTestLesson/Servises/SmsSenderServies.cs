using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DiTestLesson.Servises
{
    public class SmsSenderServies : ISmsSenderServies
    {
        public Task SendSms(string phoneNumber) 
        {

            const string accountSid = "AC7592c8089e9c480a48e7e4c62460e09f";
            const string authToken = "6cc2344e8c19865d2b88324c449f3edd";

            TwilioClient.Init(accountSid, authToken);

            return MessageResource.CreateAsync(
                body: "А вот и ваше сообщение!",
                from: new Twilio.Types.PhoneNumber("+17603873194"),
                to: new Twilio.Types.PhoneNumber("+"+phoneNumber)
            );

        }
    }
}
