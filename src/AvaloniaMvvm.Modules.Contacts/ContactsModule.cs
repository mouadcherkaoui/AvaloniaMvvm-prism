using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaMvvm.Modules.Contacts.ViewModels;
using AvaloniaMvvm.Modules.Contacts.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AvaloniaMvvm.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContactsView", typeof(ContactsView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}