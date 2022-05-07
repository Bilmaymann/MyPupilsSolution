using System.ComponentModel.DataAnnotations;

namespace MyPupils.Models
{
    public class Tolovlar
    {
        public int Id { get; set; }
        [Required]
        public DateTime Sana { get; set; }
        [Required]
        public string? Id1 { get; set; }
        [Required]
        public string? Id2 { get; set; }
        [Required]
        public string? Id3 { get; set; }
        [Required]
        public string? Id4 { get; set; }
        [Required]
        public string? Id5 { get; set; }
    }
}
