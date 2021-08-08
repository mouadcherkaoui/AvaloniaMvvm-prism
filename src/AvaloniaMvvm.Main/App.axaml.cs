using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaMvvm.ViewModels;
using AvaloniaMvvm.Views;
using Prism.Ioc;
using Prism.Unity;
using AvaloniaMvvm.Modules.Mail;
using Prism.Modularity;
using AvaloniaMvvm.Modules.Calendar;
using AvaloniaMvvm.Modules.Contacts;

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
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
        }
    }
}