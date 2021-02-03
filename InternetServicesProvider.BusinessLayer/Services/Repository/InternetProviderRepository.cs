using InternetServicesProvider.DataLayer;
using InternetServicesProvider.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetServicesProvider.BusinessLayer.Services.Repository
{
    public class InternetProviderRepository : IInternetProviderRepository
    {
        /// <summary>
        /// Creating refrerance variable of InternetServicesDbContext and injecting in Constructor
        /// </summary>
        private readonly InternetServicesDbContext _internetDbContext;
        public InternetProviderRepository(InternetServicesDbContext internetServicesDbContext)
        {
            _internetDbContext = internetServicesDbContext;
        }
        /// <summary>
        /// Get all Internet plan from Inmemory Db.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Plan>> AllInternetPlan()
        {
            var plan = await _internetDbContext.Plans.
                OrderByDescending(x => x.PlanName).ToListAsync();
            return plan;
        }
        /// <summary>
        /// Get all register complaint from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Complaint>> AllRegisterComplaint()
        {
            var complaint = await _internetDbContext.Complaints.
                OrderByDescending(x => x.ComplaintId).ToListAsync();
            return complaint;
        }
        /// <summary>
        /// get booked plan for customer by customer id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<BookedPlan> BookedPlanByCustomerId(int customerId)
        {
            var bookPlan = await _internetDbContext.BookPlans
                                .Where(x => x.CustomerId == customerId)
                                .FirstOrDefaultAsync();
            return bookPlan;
        }
        /// <summary>
        /// Book a plan by register customer
        /// </summary>
        /// <param name="bookPlan"></param>
        /// <returns></returns>
        public async Task<BookedPlan> BookPlan(int planId, Customer customer)
        {
            var plan = _internetDbContext.Plans.Where(x => x.PlanId == planId).FirstOrDefault();

            var booked = new BookedPlan()
            {
                UserName = customer.UserName,
                CustomerId = customer.CustomerId,
                PlanName = plan.PlanName,
                Email = customer.Email,
                Address = customer.Address
            };
            _internetDbContext.Add(booked);
            await _internetDbContext.SaveChangesAsync();
            return booked;
        }
        /// <summary>
        /// Get a single complaint by Complaint Id
        /// </summary>
        /// <param name="complaintId"></param>
        /// <returns></returns>
        public async Task<Complaint> ComplaintById(int complaintId)
        {
        var complaint = await _internetDbContext.Complaints
                                .Where(x => x.ComplaintId == complaintId)
                                .FirstOrDefaultAsync();
        return complaint;
        }
        /// <summary>
        /// Get Single customer by customer Id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<Customer> CustomerById(int customerId)
        {
            var customer = await _internetDbContext.Customers
                                 .Where(x => x.CustomerId == customerId)
                                 .FirstOrDefaultAsync();
            return customer;
        }

        /// <summary>
        /// Find a internet plan by plan name
        /// </summary>
        /// <param name="planName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Plan>> FindInternetPlan(string planName)
        {
            var findPlan = await _internetDbContext.Plans.
                Where(x => x.PlanName == planName).Take(10).ToListAsync();
            return findPlan;
        }
        /// <summary>
        /// Get internet plan by PlanId
        /// </summary>
        /// <param name="planId"></param>
        /// <returns></returns>
        public async Task<Plan> InternetPlanById(int planId)
        {
            var planById = await _internetDbContext.Plans
                                 .Where(x => x.PlanId == planId)
                                 .FirstOrDefaultAsync();
            return planById;
        }
        /// <summary>
        /// get plan list for dropdownlist
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Plan> Plan()
        {
            var plans = _internetDbContext.Plans.OrderByDescending(x => x.PlanName).ToList();
            return plans;
        }
        /// <summary>
        /// Register Complaint by user in InMemoryDb
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        public async Task<Complaint> RegisterComplaint(Complaint complaint)
        {
            _internetDbContext.Complaints.Add(complaint);
            await _internetDbContext.SaveChangesAsync();
            return complaint;
        }
        /// <summary>
        /// Register new Customer in InMemory Db
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public async Task<Customer> RegisterCustomer(Customer customer)
        {
            _internetDbContext.Customers.Add(customer);
            await _internetDbContext.SaveChangesAsync();
            return customer;
        }
        /// <summary>
        /// Verify customer to be book Internet plan and register complaint
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<Customer> VerifyCustomer(int customerId)
        {
            var result = await _internetDbContext.Customers
                .Where(x => x.CustomerId == customerId).FirstOrDefaultAsync();
            return result;
        }
    }
}
