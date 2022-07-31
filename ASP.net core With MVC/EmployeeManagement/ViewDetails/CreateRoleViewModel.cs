using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewDetails
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
