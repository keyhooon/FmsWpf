using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusManagement.Models;

namespace BusManagement.Data
{
    class VehicleDBInitializer : DropCreateDatabaseAlways<VehicleDbContext>
    {
        protected override void Seed(VehicleDbContext context)
        {
            IList<VehicleCompany> DefaultVehicleCompanies = new List<VehicleCompany>()
            {
                new VehicleCompany() {Name = "Renualt"},
                new VehicleCompany() {Name = "Benz"},
                new VehicleCompany() {Name = "Isaco"},
            };
            context.VehicleCompanies.AddRange(DefaultVehicleCompanies);

            IList<Fleet> DefaultFleet = new List<Fleet>()
            {
                new Fleet() {Code = "1", Name = "First Fleet"},
                new Fleet() {Code = "2", Name = "Second Fleet"},
                new Fleet() {Code = "3", Name = "Third Fleet"},
                new Fleet() {Code = "4", Name = "Forth Fleet"},
            };
            context.Fleets.AddRange(DefaultFleet);

            IList<Vehicle> DefaultVehicles = new List<Vehicle>()
            {
                new Vehicle() {PlateNumber = "PlateNumber1", Fleet = DefaultFleet[1], Company =DefaultVehicleCompanies[0]},
                new Vehicle() {PlateNumber = "PlateNumber2", Fleet = DefaultFleet[3], Company =DefaultVehicleCompanies[0]},
                new Vehicle() {PlateNumber = "PlateNumber3", Fleet = DefaultFleet[2], Company =DefaultVehicleCompanies[1]},
                new Vehicle() {PlateNumber = "PlateNumber4", Fleet = DefaultFleet[1], Company =DefaultVehicleCompanies[2]},
                new Vehicle() {PlateNumber = "PlateNumber5", Fleet = DefaultFleet[2], Company =DefaultVehicleCompanies[2]},
                new Vehicle() {PlateNumber = "PlateNumber6", Fleet = DefaultFleet[1], Company =DefaultVehicleCompanies[0]},
            };
            context.Vehicles.AddRange(DefaultVehicles);

            IList<Driver> defaultDrivers = new List<Driver>()
            {
                new Driver()
                {
                    Name = "Keyhan",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode1",
                    Vehicle = DefaultVehicles[0]
                },
                new Driver()
                {
                    Name = "Roozbeh",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode2",
                    Vehicle = DefaultVehicles[0]
                },
                new Driver()
                {
                    Name = "Kaveh",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode3",
                    Vehicle = DefaultVehicles[0]
                },
                new Driver()
                {
                    Name = "Kian",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode4",
                    Vehicle = DefaultVehicles[0]
                },
                new Driver()
                {
                    Name = "Mohammad",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode1",
                    Vehicle = DefaultVehicles[2]
                },
                new Driver()
                {
                    Name = "Sepehr",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode2",
                    Vehicle = DefaultVehicles[1]
                },
                new Driver()
                {
                    Name = "Saam",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode3",
                    Vehicle = DefaultVehicles[3]
                },
                new Driver()
                {
                    Name = "Hasan",
                    LastName = "Babazadeh",
                    LicenseCode = "LicenseCode4",
                    Vehicle = DefaultVehicles[3]
                },
            };
            context.Drivers.AddRange(defaultDrivers);


            base.Seed(context);
            context.SaveChanges();
        }
    }
}
