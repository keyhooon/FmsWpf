
namespace BusManagement.Models
{
    using System.Collections.Generic;
    
    public partial class VehicleType
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
