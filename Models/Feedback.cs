using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Concern/Issues are required")]
        public string Concern { get; set; }

        [Required(ErrorMessage = "Please select a Department/Division")]
        public string Department { get; set; }
    }
}
