using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class Employee
    {
        public int Id { get; set; }

        // ================= BASIC INFO =================

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets allowed")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabets allowed")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(
        @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|in)$",
        ErrorMessage = "Email must be valid and end with .com or .in"
        )]
        public string Email { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone must be 10 digits")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Gender { get; set; }

        // ================= DOB & AGE =================

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        // ================= JOB INFO =================

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        [Required]
        [Range(1000, 10000000, ErrorMessage = "Salary must be positive")]
        public decimal Salary { get; set; }

        // ================= ADDRESS =================

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(150)]
        public string AddressLine1 { get; set; }

        [StringLength(150)]
        public string? AddressLine2 { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Pincode must be 6 digits")]
        public string Pincode { get; set; }

        // ================= GOVERNMENT ID =================

        [Required]
        [RegularExpression(@"^[0-9]{12}$", ErrorMessage = "Aadhaar must be 12 digits")]
        public string AadhaarNumber { get; set; }

        // ================= JOINING =================

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}