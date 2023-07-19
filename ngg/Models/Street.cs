using System.ComponentModel.DataAnnotations;
namespace ngg.Models
{
    public class Street
    {
        [Key]
        public int Id { get; set; }
        public string? StreetPictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        public List <Street_House>? Streets_Houses  { get; set; }

}
}
