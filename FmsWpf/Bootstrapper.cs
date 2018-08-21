using FmsWpf.Views;
using System.Windows;
using Prism.Modularity;
using Autofac;
using DevExpress.Xpf.NavBar;
using Microsoft.Practices.Unity;
using Prism.Autofac;
using Prism.Regions;
using Prism.Unity;

namespace FmsWpf
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Show();
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            var factory = Container.Resolve<IRegionBehaviorFactory>();
            mappings.RegisterMapping(typeof(NavBarControl),
                                     DevExpress.Xpf.Prism.AdapterFactory.Make<RegionAdapterBase<NavBarControl>>(factory));
            return mappings;
        }

        protected override void ConfigureModuleCatalog()
        {
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(BusManagement.BusManagementModule));
        }
    }
}
