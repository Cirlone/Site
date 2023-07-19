using System.ComponentModel.DataAnnotations;

namespace ngg.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }
        public string? HousePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        public List<House>? Houses { get; set;}
    }
}
