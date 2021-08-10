using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaMvvm.Modules.Message.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AvaloniaMvvm.Modules.Message
{
    public class MessageModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
                containerProvider
                    .Resolve<IRegionManager>()
                    .RegisterViewWithRegion("MessageRegion", typeof(MessageView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}