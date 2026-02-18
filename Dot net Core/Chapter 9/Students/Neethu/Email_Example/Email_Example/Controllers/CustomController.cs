using Email_Example.Helpers;
using Email_Example.Service;
using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly IEmailService emailService;
        public CustomController(IEmailService emailService)
        {
               this.emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail()
        {
            try
            {
                MailRequest mailRequest = new MailRequest();
                mailRequest.ToEmail = "sajithlalcs@gmail.com";
                mailRequest.Subject = "Welcome";
                mailRequest.Body = "Thank You";
                await emailService.SendEmailAsync(mailRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
