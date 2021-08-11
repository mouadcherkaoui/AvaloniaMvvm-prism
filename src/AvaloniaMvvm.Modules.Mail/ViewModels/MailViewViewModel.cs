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
        
        public MailViewViewModel()
        {
            this.mailService = new MailService();
            this.MailMessages = new ObservableCollection<MailMessage>(mailService.Messages);
        }  

        public ObservableCollection<MailMessage> MailMessages { get; private set; }
        public string Greeting => "Mail Region";
    }
}
