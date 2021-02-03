using InternetServicesProvider.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetServicesProvider.DataLayer
{
    public class InternetServicesDbContext : DbContext
    {
        public InternetServicesDbContext(DbContextOptions<InternetServicesDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookedPlan> BookPlans { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Report> Reports { get; set; }

        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Complaint>()
                .HasKey(x => x.ComplaintId);
            modelBuilder.Entity<Customer>()
                .HasKey(x => x.CustomerId);
            modelBuilder.Entity<BookedPlan>()
                .HasKey(x => x.BookedPlanId);
            modelBuilder.Entity<Plan>()
                .HasKey(x => x.PlanId);
            modelBuilder.Entity<Report>()
                .HasKey(x => x.ReportId);
        }
    }
}
