using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaMvvm.ViewModels;
using AvaloniaMvvm.Views;
using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using AvaloniaMvvm.Modules.Mail;
using AvaloniaMvvm.Modules.Message;
using AvaloniaMvvm.Modules.Calendar;
using AvaloniaMvvm.Modules.Contacts;
using Prism.Regions;
using Avalonia.Controls;
using AvaloniaMvvm.Main.Core.RegionAdapters;

namespace AvaloniaMvvm
{
    public class App : PrismApplication
    {

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        protected override IAvaloniaObject CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
            containerRegistry.Register<StackPanelRegionAdapter>();
            containerRegistry.Register<GridRegionAdapter>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<MessageModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(Grid), Container.Resolve<GridRegionAdapter>());
        }
    }
}