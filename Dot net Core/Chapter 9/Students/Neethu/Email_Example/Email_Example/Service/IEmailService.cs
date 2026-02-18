using Email_Example.Helpers;

namespace Email_Example.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
