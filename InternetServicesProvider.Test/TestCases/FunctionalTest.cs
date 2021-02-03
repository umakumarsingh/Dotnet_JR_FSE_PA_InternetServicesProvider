using InternetServicesProvider.BusinessLayer.Interfaces;
using InternetServicesProvider.BusinessLayer.Services;
using InternetServicesProvider.BusinessLayer.Services.Repository;
using InternetServicesProvider.Entities;
using Moq;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace InternetServicesProvider.Test.TestCases
{
    public class FunctionalTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IInternetProviderServices _internetServices;
        public readonly Mock<IInternetProviderRepository> service = new Mock<IInternetProviderRepository>();
        private readonly BookedPlan _bookedPlan;
        private readonly Complaint _complaint;
        private readonly Customer _customer;
        private readonly Plan _plan;
        public FunctionalTest()
        {
            //Creating New mock Object with value.
            _internetServices = new InternetProviderServices(service.Object);
            _bookedPlan = new BookedPlan
            {
                BookedPlanId = 1,
                UserName = "Kumar Sonu",
                CustomerId = 1,
                PlanName = "Monthly",
                Email = "services@iiht.co.in",
                Address = "a/3 Banglore"
            };
            _complaint = new Complaint
            {
                ComplaintId = 1,
                Subject = "Not Working",
                Description = "Internet Plan is not working",
                CustomerId = 1,
                Email = "services@iiht.co.in",
                IsSolved = false
            };
            _customer = new Customer
            {
                CustomerId = 1,
                UserName = "Kumar Sonu",
                PhoneNumber = 9631438121,
                Address = "a/3 Banglore",
                Email = "services@iiht.co.in",
                Age = 23,
                Region = "Bihar",
                BusinessType = "Home"
            };
            _plan = new Plan
            {
                PlanId = 1,
                PlanName = "Monthly",
                Description = "Get 30 GB Data",
                PlanExpiryDate = DateTime.Now
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FunctionalTest()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Get all Internet sevices plan to validate all Services Plan
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllInternetPlan()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.AllInternetPlan());
            var result = await _internetServices.AllInternetPlan();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_GetAllInternetPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Internet plan by Plan Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetInternetPlanById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.InternetPlanById(_plan.PlanId)).ReturnsAsync(_plan);
            var result = await _internetServices.InternetPlanById(_plan.PlanId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetInternetPlanById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get internet services plan by Name, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_FindInternetPlanByName()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.FindInternetPlan(_plan.PlanName));
            var result = await _internetServices.FindInternetPlan(_plan.PlanName);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_FindInternetPlanByName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Register a Customer and return Customer object
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_RegisterCustomer()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.RegisterCustomer(_customer)).ReturnsAsync(_customer);
            var result = await _internetServices.RegisterCustomer(_customer);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_RegisterCustomer=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Customer by Customer Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetCustomerById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.CustomerById(_customer.CustomerId)).ReturnsAsync(_customer);
            var result = await _internetServices.CustomerById(_customer.CustomerId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetCustomerById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Book internet Plan and return BookPlan object
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_New_BookPlan()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.BookPlan(_plan.PlanId, _customer)).ReturnsAsync(_bookedPlan);
            var result = await _internetServices.BookPlan(_plan.PlanId, _customer);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_New_BookPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Register Complaint and return Complant object
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_New_RegisterComplaint()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.RegisterComplaint(_complaint)).ReturnsAsync(_complaint);
            var result = await _internetServices.RegisterComplaint(_complaint);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_New_RegisterComplaint=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get all Register Complaint to validate all Complaint
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_AllRegisterComplaint()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.AllRegisterComplaint());
            var result = await _internetServices.AllRegisterComplaint();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_AllRegisterComplaint=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for get Complaint by Complaint Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetComplaintById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.ComplaintById(_complaint.ComplaintId)).ReturnsAsync(_complaint);
            var result = await _internetServices.ComplaintById(_complaint.ComplaintId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetComplaintById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for verify Customer by Customer Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_VerifyCustomerById()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.VerifyCustomer(_customer.CustomerId)).ReturnsAsync(_customer);
            var result = await _internetServices.VerifyCustomer(_customer.CustomerId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_VerifyCustomerById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for verify get Booked Plan by Customer Id, if not exists test failed or passesd if its true.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_BookedPlanByCustomerId()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.BookedPlanByCustomerId(_customer.CustomerId)).ReturnsAsync(_bookedPlan);
            var result = await _internetServices.BookedPlanByCustomerId(_customer.CustomerId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_BookedPlanByCustomerId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get all Internet sevices plan to create dropdown list
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetPlanList()
        {
            //Arrange
            var res = false;
            //Action
            service.Setup(repos => repos.Plan());
            var result = _internetServices.Plan();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_GetPlanList=" + res + "\n");
            return res;
        }
    }
}
