using System;
using BusManagement.Views;
using Prism.Modularity;
using Prism.Regions;
using Autofac;
using BusManagement.Data;
using BusManagement.Services;
using Microsoft.Practices.Unity;
using Prism.Autofac;
using Prism.Unity;

namespace BusManagement
{
    public class BusManagementModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public BusManagementModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion",typeof(ViewA));
            _container.RegisterType<IVehicleUnitOfWork, VehicleDbContextUnitOfWork>();
            _container.RegisterType<FleetManagerContext>(new ContainerControlledLifetimeManager());
            _regionManager.RegisterViewWithRegion("NavBarControlRegion", typeof(VehicleNavigator));

        }
    }
}