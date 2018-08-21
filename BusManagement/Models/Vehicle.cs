
namespace BusManagement.Models
{
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
    
        public int Id { get; set; }
        public int FleetId { get; set; }
        public int? VehicleTypeId{ get; set; }
        public int? VehicleCompanyId { get; set; }
        public OwnerTypes? OwnerType { get; set; }
        public string PlateNumber { get; set; }

    
        public virtual Fleet Fleet { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public virtual VehicleCompany Company { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
