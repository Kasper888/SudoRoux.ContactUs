using System;
using System.ComponentModel.DataAnnotations;

namespace SudoRoux.ContactUs.Domain
{

    public class ContactUs
    {
        private const int minimumAge = 10;
        private const int maximumAge = 120;

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Alphabets only allowed")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Alphabets only allowed")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public bool Subscribed { get; set; }

        [DataType(DataType.Date)]
        [PastDateRange(minimumAge, maximumAge)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}


