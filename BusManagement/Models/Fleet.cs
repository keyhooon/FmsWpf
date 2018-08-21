
namespace BusManagement.Models
{
    using System.Collections.Generic;
    
    public partial class Fleet
    {
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Way> WaysLocation { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
