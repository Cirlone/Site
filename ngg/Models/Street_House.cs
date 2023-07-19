using System.IO;

namespace ngg.Models
{
    public class Street_House
    {
        public int StreetId { get; set; }
        public Street? Street { get; set; }
        public int HouseId { get; set; }
        public House? House { get; set; }
    }
}
