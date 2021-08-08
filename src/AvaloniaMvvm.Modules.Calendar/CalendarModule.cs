using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaMvvm.Modules.Calendar.ViewModels;
using AvaloniaMvvm.Modules.Calendar.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AvaloniaMvvm.Modules.Calendar
{
    public class CalendarModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("CalendarView", typeof(CalendarView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}