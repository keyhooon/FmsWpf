using BusManagement.Models;
using Infrastructure;

namespace BusManagement.Data
{
    public interface IVehicleUnitOfWork :IUnitOfWork
    {
        IRepository<Device> DeviceRepository { get; }
        IRepository<DeviceType> DeviceTypeRepository { get; }
        IRepository<Driver> DriverRepository { get; }
        IRepository<Fleet> FleetRepository { get; }
        IRepository<Station> StationRepository { get; }
        IRepository<VehicleCompany> VehicleCompanyRepository { get; }
        IRepository<Vehicle> VehicleRepository { get; }
        IRepository<VehicleType> VehicleTypeRepository { get; }
        IRepository<Way> WayRepository { get; }
    }
}