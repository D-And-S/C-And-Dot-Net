using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewDetails
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        //basically we are saying that use IsEmailInuse Method in Account controller to validate email remotely
        [Remote(action: "IsEmailInUse", controller:"Account")]
        [ValidEmailDomainAttribute(allowedDomain: "gmail.com", 
            ErrorMessage = " Email domain must be gmail.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "Passowrd and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
    }
}
