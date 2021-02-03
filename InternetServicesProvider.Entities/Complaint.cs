using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.Entities
{
    public class Complaint
    {
        [Key]
        public int ComplaintId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsSolved { get; set; }
    }
}