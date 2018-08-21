
using System;

namespace BusManagement.Models
{
   
    public partial class Driver
    {
        public int Id { get; set; }

        public int? VehicleId { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }
        public byte[] Image { get; set; }
        public string NationalId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string LicenseCode { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
    }
}
