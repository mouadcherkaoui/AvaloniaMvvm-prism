using System.Collections.Generic;
using AvaloniaMvvm.Modules.Mail.Models;

namespace AvaloniaMvvm.Modules.Mail.Services
{
    public interface IMailService
    {
        void Send(MailMessage message);
        void GetMessages(string folder);
        IEnumerable<MailMessage> Messages { get; set; }
    }
}