namespace AvaloniaMvvm.Modules.Mail.Models
{
    public class MailMessage
    {
        public int MailId { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime ReceivedOn { get; set; }
    }
}