using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RelAirLine_MVC.Models
{
    public class CustomerModel
    {
        

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        public string Suffix { get; set; }

        [Required(ErrorMessage = "Please enter your birthdate.")]
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string AddressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter your zip code.")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state.")]
        public string State { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        [Compare("EmailAddress", ErrorMessage = "The email and confirmed email do not match!")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Your password must be between 8 and 20 characters.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirmed password do not match!")]
        public string ConfirmPassword { get; set; }

    }
}