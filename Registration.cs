using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Registration
    {
        // Name
        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Enter Your Name:")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 50 characters")]
        [MaxLength(50)]
        public string Name { get; set; }

        // Age
        [Required(ErrorMessage = "Age is Required")]
        [Range(1, 120,
            ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; }

        // Address
        [Required(ErrorMessage = "Address is Required")]
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }

        // Email
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",
            ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        // Confirm Email
        [Required(ErrorMessage = "Confirm Email is Required")]
        [System.ComponentModel.DataAnnotations.Compare("Email",
            ErrorMessage = "Email Not Matched")]
        public string ConfirmEmail { get; set; }

        // Phone Number (Output format: 91-1234-567-890)
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^\d{2}-\d{4}-\d{3}-\d{3}$",
            ErrorMessage = "Phone format must be 91-1234-567-890")]
        public string Phone { get; set; }
    }
}
