using InternetServicesProvider.BusinessLayer.Interfaces;
using InternetServicesProvider.BusinessLayer.Services;
using InternetServicesProvider.BusinessLayer.Services.Repository;
using InternetServicesProvider.Entities;
using Moq;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace InternetServicesProvider.Test.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IInternetProviderServices _internetServices;
        public readonly Mock<IInternetProviderRepository> service = new Mock<IInternetProviderRepository>();
        private BookedPlan _bookedPlan;
        private readonly Complaint _complaint;
        private readonly Customer _customer;
        private readonly Plan _plan;
        public ExceptionalTest()
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
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for Register invalid Customer, if customer not null the test is faild.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_Customer()
        {
            //Arrange
            bool res = false;
            var _customerUpdate  = new Customer
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
            _customerUpdate = null;
            //Act
            service.Setup(repo => repo.RegisterCustomer(_customerUpdate)).ReturnsAsync(_customerUpdate = null);
            var result = await _internetServices.RegisterCustomer(_customerUpdate);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_Customer=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Register Complaint for Plan, if Complaint not null the test is faild.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_Complaint()
        {
            //Arrange
            bool res = false;
            var _complaintUpdate = new Complaint
            {
                ComplaintId = 1,
                Subject = "Not Working",
                Description = "Internet Plan is not working",
                CustomerId = 1,
                Email = "services@iiht.co.in",
                IsSolved = false
            };
            _complaintUpdate = null;
            //Act
            service.Setup(repo => repo.RegisterComplaint(_complaintUpdate)).ReturnsAsync(_complaintUpdate = null);
            var result = await _internetServices.RegisterComplaint(_complaintUpdate);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_Complaint=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Book Plan, if BookPlan not null the test is faild.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Invlid_BookPlan()
        {
            //Arrange
            bool res = false;
            var _customerUpdate = new Customer
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
            _customerUpdate = null;
            //Act
            service.Setup(repo => repo.BookPlan(_plan.PlanId, _customerUpdate)).ReturnsAsync(_bookedPlan = null);
            var result = await _internetServices.BookPlan(_plan.PlanId, _customerUpdate);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_Invlid_BookPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Validate Customer Mobile Number length is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidatePhoneNumber()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.RegisterCustomer(_customer)).ReturnsAsync(_customer);
            var result = await _internetServices.RegisterCustomer(_customer);
            var actualLength = _customer.PhoneNumber.ToString().Length;
            if (result.PhoneNumber.ToString().Length == actualLength)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_ValidatePhoneNumber=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor Valid Email used for test the valid Email
        /// </summary>
        [Fact]
        public async void Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            //Act
            bool isEmail = Regex.IsMatch(_customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
            res = isEmail;
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_ValidEmail=" + res + "\n");
        }
    }
}
