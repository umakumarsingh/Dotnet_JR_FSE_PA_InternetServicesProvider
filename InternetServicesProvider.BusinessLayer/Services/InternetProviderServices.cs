using System;
using InternetServicesProvider.BusinessLayer.Interfaces;
using InternetServicesProvider.BusinessLayer.Services.Repository;
using InternetServicesProvider.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetServicesProvider.BusinessLayer.Services
{
    public class InternetProviderServices : IInternetProviderServices
    {
        /// <summary>
        /// Creating referance variable of IInternetProviderRepository and injecting in Constructor
        /// </summary>
        private readonly IInternetProviderRepository _internetRepository;
        public InternetProviderServices(IInternetProviderRepository internetProviderRepository)
        {
            _internetRepository = internetProviderRepository;
        }
        /// <summary>
        /// Get all Internet plan
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Plan>> AllInternetPlan()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all register complaint for resolution
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Complaint>> AllRegisterComplaint()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get booked plan by customer id and show after customer booked plan 
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<BookedPlan> BookedPlanByCustomerId(int customerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book a Internet plan by register customer
        /// </summary>
        /// <param name="bookPlan"></param>
        /// <returns></returns>
        public async Task<BookedPlan> BookPlan(int planId, Customer customer)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a single complaint by Complaint Id
        /// </summary>
        /// <param name="complaintId"></param>
        /// <returns></returns>
        public async Task<Complaint> ComplaintById(int complaintId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get register customer details 
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<Customer> CustomerById(int customerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find internet plan by plan name.
        /// </summary>
        /// <param name="planName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Plan>> FindInternetPlan(string planName)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get internet plan by plan Id
        /// </summary>
        /// <param name="planId"></param>
        /// <returns></returns>
        public async Task<Plan> InternetPlanById(int planId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get plan list for plan drop down list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Plan> Plan()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new complaint by User, and make sure user is register before register any complaint
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public async Task<Complaint> RegisterComplaint(Complaint complaint)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new Customer, they are able to book any plan and register any complaint.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public async Task<Customer> RegisterCustomer(Customer customer)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// verify any register customer before booking any complaint and book any new plan
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<Customer> VerifyCustomer(int customerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
    }
}
