
using System.Data.Entity.Spatial;

namespace BusManagement.Models
{
    public partial class Way
    {
        public int Id { get; set; }
        public int FleetId { get; set; }
  //      public DbGeography Location { get; set; }  
        public virtual Fleet Fleet { get; set; }
    }
}
