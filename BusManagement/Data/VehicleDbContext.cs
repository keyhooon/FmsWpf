using System.Data.Entity;
using BusManagement.Models;

namespace BusManagement.Data
{
    [DbConfigurationType(typeof(VehicleDbConfiguration))]
    public class VehicleDbContext : DbContext
    {

        public VehicleDbContext() : base()
        {
            
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<VehicleCompany> VehicleCompanies { get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Fleet> Fleets { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<DeviceType> DeviceTypes { get; set; }

        public DbSet<Way> Ways{ get; set; }

        public DbSet<Station> Stations { get; set; }

    }
}
