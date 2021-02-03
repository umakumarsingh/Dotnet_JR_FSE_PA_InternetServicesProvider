using System;
using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.Entities
{
    public class Plan
    {
        [Key]
        [Display(Name = "Plan Id")]
        public int PlanId { get; set; }
        [Required]
        [Display(Name = "Plan Name")]
        public string PlanName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Plan Expiry Date")]
        public DateTime PlanExpiryDate { get; set; }
    }
}
