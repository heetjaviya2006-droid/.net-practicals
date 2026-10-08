using System.ComponentModel.DataAnnotations;

namespace prac7.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Feedback is required")]
        [StringLength(200, ErrorMessage = "Feedback must be within 200 characters")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please select rating")]
        public int Rating { get; set; }
    }
}