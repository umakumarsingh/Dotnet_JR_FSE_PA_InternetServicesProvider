using InternetServicesProvider.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace InternetServicesProvider.BusinessLayer.ViewModels
{
    public class PlanViewModel
    {
        [Required]
        [Display(Name = "Plan Name")]
        public string PlanName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Plan Expiry Date")]
        public DateTime PlanExpiryDate { get; set; }
        public IEnumerable<Plan> Plans { get; set; }
        public int PlanPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Plans.Count() / (double)PlanPerPage));
        }
        public IEnumerable<Plan> PaginatedPlan()
        {
            int start = (CurrentPage - 1) * PlanPerPage;
            return Plans.OrderBy(b => b.PlanId).Skip(start).Take(PlanPerPage);
        }
    }
}
