using System.ComponentModel.DataAnnotations;

namespace DaFED.Models
{
    public class InsertNewCandidateDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [Range(10, 46)]
        public int Age { get; set; }
        [Required]
        public Quality Quality { get; set; }
    }
}
