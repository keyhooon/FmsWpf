using BusManagement.ViewModels;
using DevExpress.Xpf.NavBar;
using Microsoft.Practices.Unity;
using Prism.Mvvm;

namespace BusManagement.Views
{
    /// <summary>
    /// Interaction logic for NavBar.xaml
    /// </summary>
    public partial class VehicleNavigator : NavBarGroup
    {
        private readonly IUnityContainer _container;

        public VehicleNavigator(IUnityContainer container)
        {
            _container = container;
            InitializeComponent();
            DataContext = _container.Resolve<VehicleNavigatorViewModel>();

        }
    }
}
