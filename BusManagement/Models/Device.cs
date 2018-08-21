
namespace BusManagement.Models
{
    public partial class Device
    {
        
    
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public string Serial { get; set; }
        public long Imei { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
    }
}
