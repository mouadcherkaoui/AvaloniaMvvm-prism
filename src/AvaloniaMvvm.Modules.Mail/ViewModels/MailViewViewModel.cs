using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AvaloniaMvvm.Modules.Mail.Models;
using AvaloniaMvvm.Modules.Mail.Services;

namespace AvaloniaMvvm.Modules.Mail.ViewModels
{
    public class MailViewViewModel : ViewModelBase
    {
        private IMailService mailService;
        public MailViewViewModel(IMailService mailService)
        {
            this.mailService = mailService;
            this.Mails = new ObservableCollection<MailMessage>(mailService.Messages);
        }  

        public ObservableCollection<MailMessage> Mails { get; set; } = new ObservableCollection<MailMessage>();
        public string Greeting => "Mail Region";
    }
}
