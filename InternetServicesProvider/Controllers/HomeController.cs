using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetServicesProvider.Models;
using InternetServicesProvider.BusinessLayer.Interfaces;
using InternetServicesProvider.BusinessLayer.ViewModels;
using InternetServicesProvider.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InternetServicesProvider.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Creating Referance variable of IInternetProviderServices and injecting in Controller constructor
        /// </summary>
        private readonly IInternetProviderServices _internetServices;
        public HomeController(IInternetProviderServices internetProviderServices)
        {
            _internetServices = internetProviderServices;
        }
        /// <summary>
        /// Get all Internet Plan, serach internet plan by name.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string search, int page = 1)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get internet plan by plan Id and show the plan details before book.
        /// </summary>
        /// <param name="planId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int planId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new Customer for performing book internet plan and book any complaint.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RegisterNewCustomer()
        {
            return View();
        }
        /// <summary>
        /// Register new Customer for performing book internet plan and book any complaint- post method
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterNewCustomer(Customer customer)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get customer details after customer get registred
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CustomerDetails(int CustomerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book internet plan for register customer.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BookNewPlan()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book internet plan for register customer, before book plan user must be verified and register
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> BookNewPlan([FromQuery] int PlanId, BookedPlanViewModel bookedPlan)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get order plan information if you successfully book any plan, with registred Customer Id
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OrderPlanInfo([FromQuery]int CustomerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show information about not registred user.
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public IActionResult UserNotvalid([FromQuery] int CustomerId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register a new complaint for any services plan
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RegisterComplaint()
        {
            return View();
        }
        /// <summary>
        /// Register a new complaint for any services plan, to register a complaint customer must be register and verified
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterComplaint(Complaint complaint)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get complaint details after complaint is booked
        /// </summary>
        /// <param name="ComplaintId"></param>
        /// <returns></returns>
        public async Task<IActionResult> ComplaintDetails([FromQuery] int ComplaintId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Prvacy Page
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Error Page
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
