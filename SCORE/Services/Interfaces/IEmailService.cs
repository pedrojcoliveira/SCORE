using SendGrid.Helpers.Mail;
using SendGrid;

namespace SCORE.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string content);
    }
    public class SendGridMailService : IEmailService
    {
        private IConfiguration _configuration;

        public SendGridMailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("scoreutad@gmail.com", "SCORE");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
