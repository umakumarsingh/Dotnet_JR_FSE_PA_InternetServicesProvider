using InternetServicesProvider.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace InternetServicesProvider.DataLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InternetServicesDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<InternetServicesDbContext>>()))
            {
                if (context.Plans.Any())
                {
                    return;   // Data was already seeded
                }
                context.Plans.AddRange(
                    new Plan
                    {
                        PlanId = 1,
                        PlanName = "Monthly",
                        Description = "Get 30 GB Data",
                        PlanExpiryDate = DateTime.Now
                    });
                context.SaveChanges();
            }
        }
    }
}