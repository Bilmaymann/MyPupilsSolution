using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPupils.Models
{
    public class Pupil
    {
        public int Id { get; set; }
        [Required]
        public string Learner { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountOfSalary { get; set; }
    }
}
