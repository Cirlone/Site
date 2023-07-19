using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngg.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string? HousePictureURL { get; set; }
        public string? FullName { get; set;}
        public string? Bio { get; set;}
        public List<Street_House>? Streets_Houses { get; set; }
        public int StreetID { get; set; }
        [ForeignKey("StreetID")]  
        public Street? Street { get; set; }  
        
        public List<Agent>? Agents  { get; set; }
        public int AgentID { get; set; }
        [ForeignKey("AgentID")]
        public Agent? Agent { get; set; }

    }
}
