﻿using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.Entities
{
    public class BookedPlan
    {
        [Key]
        public int BookedPlanId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name ="Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Plan Name")]
        public string PlanName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public virtual Plan Plans { get; set; }
    }
}
