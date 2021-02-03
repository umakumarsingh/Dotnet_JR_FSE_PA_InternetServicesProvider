using System.ComponentModel.DataAnnotations;

namespace InternetServicesProvider.Entities
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        [Required]
        public int ComplaintId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string Solution { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
