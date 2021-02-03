﻿using InternetServicesProvider.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetServicesProvider.BusinessLayer.Services.Repository
{
    public interface IInternetProviderRepository
    {
        /// <summary>
        /// All Curd operation method
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Plan>> AllInternetPlan();
        Task<Plan> InternetPlanById(int planId);
        Task<IEnumerable<Plan>> FindInternetPlan(string planName);
        Task<Customer> RegisterCustomer(Customer customer);
        Task<Customer> CustomerById(int customerId);
        Task<Complaint> RegisterComplaint(Complaint complaint);
        Task<BookedPlan> BookPlan(int planId, Customer customer);
        Task<IEnumerable<Complaint>> AllRegisterComplaint();
        Task<Complaint> ComplaintById(int complaintId);
        Task<Customer> VerifyCustomer(int customerId);
        Task<BookedPlan> BookedPlanByCustomerId(int customerId);
        IEnumerable<Plan> Plan();
    }
}
