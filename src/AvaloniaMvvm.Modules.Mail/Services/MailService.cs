using System.Collections.Generic;
using AvaloniaMvvm.Modules.Mail.Models;

namespace AvaloniaMvvm.Modules.Mail.Services
{
    public class MailService : IMailService
    {
        public IEnumerable<MailMessage> Messages { get; set; }
            = new List<MailMessage>() {
                new MailMessage() {
                    From = "avalonia@server.org",
                    Subject = "Test",
                    Content = "Test"
                },
                new MailMessage() {
                    From = "avalonia@server.org",
                    Subject = "Test",
                    Content = "Test"
                }
            };

        public void GetMessages(string folder)
        {
            throw new System.NotImplementedException();
        }

        public void Send(MailMessage message)
        {
            throw new System.NotImplementedException();
        }
    }
}