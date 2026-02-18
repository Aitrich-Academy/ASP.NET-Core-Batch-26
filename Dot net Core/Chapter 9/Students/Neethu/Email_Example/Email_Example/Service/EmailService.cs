using Email_Example.Helpers;
using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace Email_Example.Service
{
    public class EmailService:IEmailService
    {
        private readonly EmailSettings emailSettings;
        public EmailService(IOptions<EmailSettings> options)
        {
            this.emailSettings = options.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(emailSettings.Email);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject=mailRequest.Subject;
            var builder=new BodyBuilder();
            builder.HtmlBody=mailRequest.Body;
            email.Body=builder.ToMessageBody();
            var smtp = new SmtpClient();
            smtp.Connect(emailSettings.Host,emailSettings.Port,SecureSocketOptions.StartTls);
            smtp.Authenticate(emailSettings.Email,emailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
           

        }
    }
}
