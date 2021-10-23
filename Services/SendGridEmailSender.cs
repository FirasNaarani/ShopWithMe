using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Services
{
    public class SendGridEmailSender : IEmailSender
    {
        public SendGridEmailSender(
            IOptions<SendGridEmailSenderOptions> options
            )
        {
            this.Options = options.Value;
        }

        public SendGridEmailSenderOptions Options { get; set; }

        public async Task SendEmailAsync(string email,string subject,string message)
        {
            await Execute(Options.ApiKey, subject, message, email);
        }

        private async Task<Response> Execute(string apiKey,string subject,string message,string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(Options.SenderEmail, Options.SenderName),
                Subject = "Join Invitation ",
                PlainTextContent = message,
                HtmlContent = "<center><aside><h3>I'am Using 'Shop With Me Application' to facilitate the shopping process, I need your help with shopping<h3/><a href='" + message + "'>.:: Join Me ::.</a><br/><address>Shop Wth Me Support Team</address><aside/><center/>"
            };
            msg.AddTo(new EmailAddress(email));

            // disable tracking settings
            // ref.: https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);
            msg.SetOpenTracking(false);
            msg.SetGoogleAnalytics(false);
            msg.SetSubscriptionTracking(false);
            
            return await client.SendEmailAsync(msg);
        }
    }

    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        //Task<Response> Execute(string apiKey,string subject,string message,string email);
    }
}
