using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public double PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        [Display(Name = "Business Type")]
        public string BusinessType { get; set; }
    }
}
