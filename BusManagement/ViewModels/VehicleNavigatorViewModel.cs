using System.Collections.ObjectModel;
using System.Linq;
using BusManagement.Data;
using BusManagement.Models;
using BusManagement.Services;
using DevExpress.Mvvm;
using Infrastructure;

namespace BusManagement.ViewModels
{
    public class VehicleNavigatorViewModel : BindableBase
    {
        private readonly FleetManagerContext _fleetManagerContext;


        public VehicleNavigatorViewModel(FleetManagerContext fleetManagerContext)
        {
            _fleetManagerContext = fleetManagerContext;
            _fleets = _fleetManagerContext.Fleets;
            _fleetManagerContext.FleetLoaded += (sender, args) =>
            {
                Fleets = fleetManagerContext.Fleets;
            };
            if (!_fleetManagerContext.IsLoaded)
                _fleetManagerContext.LoadAsync();
        }

        private ObservableCollection<Fleet> _fleets;

        public ObservableCollection<Fleet> Fleets
        {
            get => _fleets;
            private set => SetProperty(ref _fleets, value, "");
        }




    }
}
