using System;
using BusManagement.Data;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using BusManagement.Models;
using Infrastructure;

namespace BusManagement.Services
{
    public class FleetManagerContext
    {
        private readonly IVehicleUnitOfWork _vehicleUnitOfWork;
        readonly IRepository<Fleet> _fleetRepository;
        private ObservableCollection<Fleet> _fleets;
        public event EventHandler FleetLoaded;

        public FleetManagerContext(IVehicleUnitOfWork vehicleUnitOfWork)
        {
            _vehicleUnitOfWork = vehicleUnitOfWork;

            _fleetRepository = _vehicleUnitOfWork.FleetRepository;

        }

        public async void LoadAsync()
        {
            var loadQuery = _fleetRepository.Get().Include(fleet => fleet.Vehicles.Select(vehicle => vehicle.Devices))
                .Include(fleet => fleet.WaysLocation);

            Fleets = new ObservableCollection<Fleet>(await loadQuery.ToListAsync());
            IsLoaded = true;
        }

        public ObservableCollection<Fleet> Fleets
        {
            get => _fleets;
            private set
            {
                if (_fleets == value)
                    return;
                _fleets = value;
                OnFleetLoaded();

            }
        }

        public bool IsLoaded { get; set; }

        protected virtual void OnFleetLoaded()
        {
            FleetLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
