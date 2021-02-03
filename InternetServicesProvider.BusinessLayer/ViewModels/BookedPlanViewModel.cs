using InternetServicesProvider.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.BusinessLayer.ViewModels
{
    public class BookedPlanViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Plan Name")]
        public string PlanName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }
        public IEnumerable<Plan> Plans { get; set; }
    }
}
