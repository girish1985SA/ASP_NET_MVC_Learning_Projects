using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{

    public enum Department
    {
        None,     // Default value indicating no selection
        HR,       // Human Resources
        Payroll,  // Payroll Department
        IT        // Information Technology
    }
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the email address.")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter the mobile number.")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Please enter a valid 10-digit mobile number.")]
        public string? MobileNumber { get; set; }
        

        [Required(ErrorMessage = "Please select a department.")]
        public Department? Department { get; set; }
    }
}
