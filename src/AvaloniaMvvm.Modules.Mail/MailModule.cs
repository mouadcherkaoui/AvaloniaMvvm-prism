using AvaloniaMvvm.Modules.Mail.Services;
using AvaloniaMvvm.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AvaloniaMvvm.Modules.Mail
{
    public class MailModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MailView", typeof(MailView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IMailService, MailService>();
        }
    }
}