using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiTestLesson.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using DiTestLesson.Servises;

namespace DiTestLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiesController : ControllerBase
    {
        private readonly IEntityServies entityServies;
        private readonly IEmailSenderServies emailSender;
        private readonly ISmsSenderServies smsSender;
        public ServiesController(IEntityServies entityServies, IEmailSenderServies emailSender, ISmsSenderServies smsSender)
        {
            this.entityServies = entityServies;
            this.emailSender = emailSender;
            this.smsSender = smsSender;
        }
        //public IEntityServies servies { get; set; } //1й способ
        [HttpPost]
        public async Task<IActionResult> SaveEntity(EntityDTO entity)
        {
            //var entitySaver = new EntitySaverServies();
            //await entitySaver.SaveEntity(entity);
            await entityServies.SaveEntity(entity);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> SendEmail(string to,string title, string text)
        {

            EmailMessageDTO emailMessage = new EmailMessageDTO
            {
                To = to,
                Text = text,
                Title = title
            };
            //еще какие то настройки
            //var emailSender = new EmailSenderServies();
            //await emailSender.SendEmail(emailMessage);
            await emailSender.SendEmail(emailMessage);
                return Ok();
            
        }
        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetCodeVerification(string phoneNumber)
        {
            //  var smsServies = new SmsSenderServies();
            //await smsServies.SendSms(phoneNumber);
            await smsSender.SendSms(phoneNumber);
            return Ok();
        }
    }
}