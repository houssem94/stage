using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        [Display(Name = "Last Name : ")]
        public string LastName { get; set; }
        [Display(Name = "First Name : ")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date : ")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Gender : ")]
        public string Sexe { get; set; }
        [Display(Name = "HomePhone Number : ")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string HomePhone { get; set; }
        [Display(Name = "CellPhone Number : ")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string CellPhone { get; set; }
        [Display(Name = "FaxPhone Number : ")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string FaxPhone { get; set; }
        [DataType(DataType.ImageUrl), Display(Name = "Image : ")]
        public string Image { get; set; }
        [Display(Name = "Country : ")]
        public string Country { get; set; }
        [Display(Name = "City : ")]
        public string City { get; set; }
        [Display(Name = "Address : ")]
        public string Address { get; set; }
        [Display(Name = "Resume : ")]
        public string Resume { get; set; }
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

}
