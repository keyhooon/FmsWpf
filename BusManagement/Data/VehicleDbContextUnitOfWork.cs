using BusManagement.Models;
using Infrastructure;

namespace BusManagement.Data
{
    public class VehicleDbContextUnitOfWork : DbContextUnitOfWork<VehicleDbContext>, IVehicleUnitOfWork
    {
        private DbContextRepository<Vehicle> _vehicleRepository;
        public DbContextRepository<Vehicle> VehicleRepository => _vehicleRepository ?? (_vehicleRepository = GetRepository<Vehicle>());

        private DbContextRepository<Device> _deviceRepository;
        public DbContextRepository<Device> DeviceRepository => _deviceRepository ?? (_deviceRepository = GetRepository<Device>());

        private DbContextRepository<DeviceType> _deviceTypeRepository;
        public DbContextRepository<DeviceType> DeviceTypeRepository => _deviceTypeRepository ?? (_deviceTypeRepository = GetRepository<DeviceType>());

        private DbContextRepository<Driver> _driverRepository;
        public DbContextRepository<Driver> DriverRepository => _driverRepository ?? (_driverRepository = GetRepository<Driver>());

        private DbContextRepository<Fleet> _fleetRepository;
        public DbContextRepository<Fleet> FleetRepository => _fleetRepository ?? (_fleetRepository = GetRepository<Fleet>());

        private DbContextRepository<Station> _stationRepository;
        public DbContextRepository<Station> StationRepository => _stationRepository ?? (_stationRepository = GetRepository<Station>());

        private DbContextRepository<VehicleCompany> _vehicleCompanyRepository;
        public DbContextRepository<VehicleCompany> VehicleCompanyRepository => _vehicleCompanyRepository ?? (_vehicleCompanyRepository = GetRepository<VehicleCompany>());

        private DbContextRepository<VehicleType> _vehicleTypeRepository;
        public DbContextRepository<VehicleType> VehicleTypeRepository => _vehicleTypeRepository ?? (_vehicleTypeRepository = GetRepository<VehicleType>());

        private DbContextRepository<Way> _wayRepository;
        public DbContextRepository<Way> WayRepository => _wayRepository ?? (_wayRepository = GetRepository<Way>());

        IRepository<Device> IVehicleUnitOfWork.DeviceRepository => DeviceRepository;

        IRepository<DeviceType> IVehicleUnitOfWork.DeviceTypeRepository => DeviceTypeRepository;

        IRepository<Driver> IVehicleUnitOfWork.DriverRepository => DriverRepository;

        IRepository<Fleet> IVehicleUnitOfWork.FleetRepository => FleetRepository;

        IRepository<Station> IVehicleUnitOfWork.StationRepository => StationRepository;

        IRepository<VehicleCompany> IVehicleUnitOfWork.VehicleCompanyRepository => VehicleCompanyRepository;

        IRepository<Vehicle> IVehicleUnitOfWork.VehicleRepository => VehicleRepository;

        IRepository<VehicleType> IVehicleUnitOfWork.VehicleTypeRepository => VehicleTypeRepository;

        IRepository<Way> IVehicleUnitOfWork.WayRepository => WayRepository;
    }
}
