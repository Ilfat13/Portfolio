using MimeKit;
using PortfolioMisc.Models;

namespace PortfolioMisc.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public void SendGmail(EmailModel emailModel)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress($"{emailModel.name}", ""));
            message.To.Add(new MailboxAddress("", "ilfatka.ytka@gmail.com"));
            message.Body = new BodyBuilder() { HtmlBody = $"<div>Телефон для связи: {emailModel.mobileNumber}</div><div>{emailModel.message}</div>" }.ToMessageBody();

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("nice.blaze@gmail.com", "Arbuuze1");
                client.Send(message);

                client.Disconnect(true);
            }
        }

    }
}