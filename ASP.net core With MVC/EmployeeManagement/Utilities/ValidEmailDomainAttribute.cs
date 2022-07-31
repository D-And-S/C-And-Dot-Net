using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Utilities
{
    // to use custom validation we need to derived from abstract class ValidationAttribute
    // In this example will validate email to accept only gmail.com as email domain
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private string _allowedDomain;

        public ValidEmailDomainAttribute(string allowedDomain)
        {
             _allowedDomain = allowedDomain.ToLower();
        }
        public override bool IsValid(object value)
        {
            string[] strings = value.ToString().Split('@');
            return strings[1].ToLower() == _allowedDomain;
        }
    }
}
