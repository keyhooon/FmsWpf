
namespace BusManagement.Models
{
    public class Station
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int WayId { get; set; }

        public Way Way { get; set; }

        
    }
}
