using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;

namespace IdentityManager.Services
{
    public class MailJetEmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public MailJetOptions MailJetOptions;

        public MailJetEmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailJetOptions = _configuration.GetSection("MailJet").Get<MailJetOptions>();

            var client =
                new MailjetClient(MailJetOptions.ApiKey, MailJetOptions.SecretKey);
            var request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
                    .Property(Send.FromEmail, "mydatng@gmail.com")
                    .Property(Send.FromName, "dat")
                    .Property(Send.Subject, subject)
                    .Property(Send.HtmlPart, htmlMessage)
                    .Property(Send.Recipients, new JArray {
                        new JObject {
                            {"Email", email}
                        }
                    });
            var response = await client.PostAsync(request);
        }
    }
}
