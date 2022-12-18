using System.ComponentModel.DataAnnotations;

namespace Lab_3.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(10, ErrorMessage = "First Name must be 10 characters or less.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "First Name may not contain numbers or special characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(10, ErrorMessage = "Last name must be 10 characters or less.")]
        [RegularExpression("[a-zA-Z]+$",
            ErrorMessage = "Last name may not contain numbers or special characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Street Address")]
        public string? StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        [StringLength(2, ErrorMessage = "State must be 2 characters.")]
        [RegularExpression("[a-zA-Z]{2}",
            ErrorMessage = "State may not contain numbers or special characters")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please enter a Zipcode")]
        [StringLength(5, ErrorMessage = "Zipcode must be 5 digits.")]
        [RegularExpression("[0-9]{5}",
            ErrorMessage = "Zipcode may not contain numbers or special characters")]
        public string? ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Number")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Phone Number must be 10 digits.")]
        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$",
            ErrorMessage = "Phone Number may not contain numbers or special characters")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string? Email { get; set; }
    }
}
