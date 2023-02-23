using System.ComponentModel.DataAnnotations;

namespace DaFED.Models
{
    public class InsertNewCandidateDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(5)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(4)]
        public string LastName { get; set; }
        [Required]
        [Range(45, 46)]
        public int Age { get; set; }
        [Required]
        public Quality Quality { get; set; }
    }
}
